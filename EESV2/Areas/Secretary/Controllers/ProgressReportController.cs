using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class ProgressReportController : Controller
    {
        IUnitOfWork _uw;
        IWebHostEnvironment _environment;
        public ProgressReportController(IUnitOfWork uw, IWebHostEnvironment environment)
        {
            _uw = uw;
            _environment = environment;
        }
        public IActionResult ProgressReports(int? impartID)
        {
            if (impartID==null)
            {
                return BadRequest();
            }
            Impart impart = _uw.ImpartRepository.Get(i=>i.ID== (int)impartID,include:s=>s
                                                    .Include(i=>i.Reports)
                                                    .Include(i=>i.Proposal))
                                                    .SingleOrDefault();
            
            if (impart==null)
            {
                return BadRequest();
            }
            ViewData["impart"] = impart;
            return View();
        }


        [HttpGet]
        public IActionResult GetAttachedFile(int? ReportID)
        {
            if (ReportID==null)
            {
                return BadRequest();
            }
            ProgressReport progressReport = _uw.ProgressReportRepository.GetById((int)ReportID);
            if (progressReport==null)
            {
                return BadRequest();
            }
            string path = _environment.ContentRootPath + "\\AttachmentFiles\\" + progressReport.File;
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    byte[] data = new byte[fs.Length];
                    fs.Read(data, 0, data.Length);
                    return File(data, "text/h323", progressReport.File);
                }
            }
            catch (Exception ex)
            {
                return Redirect("/Messages/NotFoundFile");
            }
        }
    }
}
