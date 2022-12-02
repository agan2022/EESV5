using AutoMapper;
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
    public class NewQualitativeEvaluationController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        private readonly IUtilities _utilities;
        public NewQualitativeEvaluationController(IUnitOfWork uw,IMapper mapper,IUtilities utilities)
        {
            _uw = uw;
            _mapper = mapper;
            _utilities = utilities;
        }
        [HttpGet]
        public IActionResult Create(int? id)//ای دی ارجاع
        {
            if (id==null)
            {
                return BadRequest();
            }
            var result = _uw.ReferralRepository.Get(r=>r.ID==id&&r.Reciver.Username==User.Identity.Name&&r.NewQualityEvaluation == null).Select(s=>new {proposalID=s.ProposalID,referralID=s.ID }).SingleOrDefault();
            if (result == null)
            {
                return BadRequest();
            }
            ViewData["proposalID"] = result.proposalID;
            ViewData["referralID"] = result.referralID;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateNewQualitativeEvaluationViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ProposalID==null || model.ReferralID == null)
                {
                    return BadRequest();
                }
                Referral referral = _uw.ReferralRepository.Get(r => r.ID == (int)model.ReferralID&&r.ProposalID==(int)model.ProposalID&&r.Reciver.Username==User.Identity.Name&&r.NewQualityEvaluation==null,include:s=>s
                                                                                                .Include(r => r.Proposal))
                                                                                                .SingleOrDefault();
                if (referral==null)
                {
                    return BadRequest();
                }
                NewQualityEvaluation newQualityEvaluation = new NewQualityEvaluation();
                if ((bool)model.PishOk)
                {
                    newQualityEvaluation = _mapper.Map<NewQualityEvaluation>(model);
                }
                else
                {
                    if (string.IsNullOrEmpty(model.RejectReason))
                    {
                        ModelState.AddModelError("","در صورت رد پیشنهاد دلیل رد آن الزامی است");
                        return View(model);
                    }
                    newQualityEvaluation.PishOk = model.PishOk;
                    newQualityEvaluation.Quality = model.Quality;
                    newQualityEvaluation.HrWork = model.HrWork;
                    newQualityEvaluation.RejectReason = model.RejectReason;
                }
                int senderID = _uw.UserRepository.Get(u => u.Username == User.Identity.Name).Select(u => u.ID).SingleOrDefault();
                int reciverID = _uw.UserRepository.Get(u=>u.UserRoles.Any(ur=>ur.Role.Title=="Secretary"),include:s=>s
                                                                                            .Include(u=>u.UserRoles).ThenInclude(ur=>ur.Role))
                                                                                            .Select(u => u.ID).ToList()[0];
                Referral newReferral = new Referral()
                {
                    NewQualityEvaluation = newQualityEvaluation,
                    SenderID = senderID,
                    ReciverID = reciverID,
                    ProposalID = referral.ProposalID,
                    StatusID = 2,
                    EvaluationTypeID = 2,
                    Date = _utilities.GetDate(),
                    IP = _utilities.GetUSRIP(HttpContext),
                    Time = _utilities.GetTime(),
                    Description = "انجام ارزیابی",
                    Result = ((bool)model.PishOk ? "پیشنهاد مورد تایید میباشد" : "پیشنهاد مورد تایید نمیباشد"),
                };
                _uw.ReferralRepository.Create(newReferral);
                _uw.NewQualityEvaluationRepository.Create(newQualityEvaluation);
                referral.StatusID = 3;//ارزیابی شده
                referral.Proposal.StatusID = 6;//عودت از ارزیابی به دبیرخانه
                _uw.ReferralRepository.Update(referral);
                _uw.ProposalRepository.Update(referral.Proposal);
                await _uw.SaveChangesAsync();
                return RedirectToAction("SuccessOperation", "Messages");
            }
            return View(model);
        }

    }
}
