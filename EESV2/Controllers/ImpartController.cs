using AutoMapper;
using EESV2.DAL.EditModels;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using EESV2.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Controllers
{
    [Authorize]
    public class ImpartController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IUtilities _utilities;
        private readonly IMapper _mapper;
        public ImpartController(IUnitOfWork uw,IMapper mapper,IUtilities utilities)
        {
            _uw = uw;
            _mapper = mapper;
            _utilities = utilities;
        }


        [HttpGet]
        public IActionResult Imparts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EstimationCostForm(int ImpartID)
        {
            Impart impart =_uw.ImpartRepository.Get(i=>i.ID==ImpartID,include:s=>s
                                                                .Include(i=>i.Proposal)
                                                                .Include(i=>i.Executor).ThenInclude(e=>e.Office)
                                                                .Include(i=>i.Hamkaran))
                                                                .SingleOrDefault();

            //اگر قبلا فرم پر شده بود نمیتواند دوباره انرا پرکند
            if (!String.IsNullOrEmpty(impart.StartDateExecute))
            {
                if (impart.ImpartStatusID!=4)
                {
                    ViewData["isReadOnly"] = true;
                }
            }
            EstimationCostFormEditModel model = _mapper.Map<EstimationCostFormEditModel>(impart);
            model.SubjectPr = impart.Proposal.SubjectPr;
            model.OfficeName = impart.Executor.Office.Name;
            model.ExecutorUserName = impart.Executor.Username;
            model.HamkaranIDs = impart.Hamkaran.Select(x => x.UserID).ToArray();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EstimationCostForm(EstimationCostFormEditModel model)
        {
            if (ModelState.IsValid)
            {
                Impart impart = _uw.ImpartRepository.Get(i=>i.ID==model.ID,include:s=>s
                                                                            .Include(i=>i.Hamkaran))
                                                                            .SingleOrDefault();
                //فقط پیشنهاداتی که در وضعیت نامشخص قرار دارند و پیشنهاداتی که از طرف مدیریت تصمیم اصلاح گرفته شده است قابل ویرایش هستند
                if (impart.ImpartStatusID!=4&&impart.ImpartStatusID!=1)
                {
                    return BadRequest();
                }

                List<UserImpart> hamkaran=new List<UserImpart>();
                if (model.HamkaranIDs!=null)
                {
                    foreach (var userid in model.HamkaranIDs.Distinct())
                    {
                        UserImpart hamkar = new UserImpart()
                        {
                            UserID = Convert.ToInt32(userid),
                            ImpartID = impart.ID
                        };
                        hamkaran.Add(hamkar);
                    }
                }
                if (impart.Hamkaran.Count!=0)
                {
                    foreach (var Hamkar in impart.Hamkaran)
                    {
                        _uw.UserImpartRepository.Delete(Hamkar);
                    }

                }
                impart.StartDateExecute = model.StartDateExecute;
                impart.EndDateExecute = model.EndDateExecute;
                impart.Cost = model.Cost;
                impart.TimeToExecute = model.TimeToExecute;
                impart.DescriptionExecute = model.DescriptionExecute;
                impart.Hamkaran = hamkaran;
                impart.ExecutorRegistrationDate = _utilities.GetDate();
                impart.ExecutorRegistrationTime = _utilities.GetTime();
                impart.ImpartStatusID = 3;//انجام برآورد مجری - منتظر تایید دبیرخانه نظام مشارکت
                _uw.ImpartRepository.Update(impart);
                await _uw.SaveChangesAsync();
            }
            return RedirectToAction("Imparts");
        }
    }
}
