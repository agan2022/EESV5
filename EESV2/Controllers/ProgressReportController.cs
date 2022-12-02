using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using EESV2.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Controllers
{
    [Authorize]
    public class ProgressReportController : Controller
    {
        IUnitOfWork _uw;
        IUtilities _utilities;
        IWebHostEnvironment _environment;
        public ProgressReportController(IUnitOfWork uw,IUtilities utilities, IWebHostEnvironment environment)
        {
            _uw = uw;
            _utilities = utilities;
            _environment = environment;
        }

        public IActionResult Imparts()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddProgressReport(int impartID)
        {
            string Executor = _uw.ImpartRepository.Get(i => i.ID == impartID)
                                                        .Select(i=>i.Executor.Username)
                                                        .SingleOrDefault();
            if (Executor != User.Identity.Name)//اگر این کاربر مجری ابلاغ نباشد
            {
                return BadRequest();
            }
            AddProgressReport model = new AddProgressReport()
            {
                ImpartID = impartID
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddProgressReport(AddProgressReport model,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                Impart impart = _uw.ImpartRepository.Get(i => i.ID == (int)model.ImpartID, include: s => s
                                                              .Include(i => i.Executor)
                                                              .ThenInclude(e => e.Office)
                                                              .Include(i => i.Proposal)
                                                              .Include(i => i.Reports)).SingleOrDefault();
                if (impart.Executor.Username != User.Identity.Name)//اگر این کاربر مجری ابلاغ نباشد
                {
                    return BadRequest();
                }
                int totalpercent = impart.Reports.Sum(r => r.Percentage) + model.Percentage;
                if ( totalpercent> 100)
                {
                    ModelState.AddModelError("ErrorMessage", "مجموع درصد های پیشرفت نباید بیشتر از صد درصد شود.");
                    return View(model);
                }
                string fileName = null;
                if (file != null)
                {
                    if (Path.GetExtension(file.FileName) != ".rar" && Path.GetExtension(file.FileName) != ".zip" && Path.GetExtension(file.FileName) != ".7z") 
                    {
                        ModelState.AddModelError("ErrorMessage", "پسوند فایل ضمیمه باید یکی از انواع zip،rar،7z باشد.");
                        return View(model);
                    }
                    if (file.Length / 1024 / 1024 > 10)
                    {
                        ModelState.AddModelError("ErrorMessage", "حجم فایل حداکثر باید 10 مگابایت باشد .");
                        return View(model);
                    }
                    string randomName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    fileName = randomName;
                    string path = _environment.ContentRootPath + "\\AttachmentFiles\\" + randomName;

                    using (Stream stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    };
                }
                ProgressReport progressReport = new ProgressReport()
                {
                    Date = _utilities.GetDate(),
                    Time = _utilities.GetTime(),
                    IP = _utilities.GetUSRIP(HttpContext),
                    Defects = model.Defects,
                    Description = model.Description,
                    ImpartID = impart.ID,
                    Percentage = model.Percentage,
                    File= fileName
                };
                if (totalpercent == 100)
                {
                    Proposal proposal = impart.Proposal;
                    proposal.StatusID = 5;
                    _uw.ProposalRepository.Update(proposal);
                }
                _uw.ProgressReportRepository.Create(progressReport);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Imparts");
            }
            return View(model);
        }
    }
}
