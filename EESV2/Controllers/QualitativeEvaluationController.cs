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
    public class QualitativeEvaluationController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IUtilities _utilities;
        public QualitativeEvaluationController(IUnitOfWork uw,IUtilities utilities)
        {
            _uw = uw;
            _utilities = utilities;
        }

        [HttpGet]
        public IActionResult Form(int referralID)
        {
            ViewData["ReferralID"] = referralID;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Form(CreateQualitativeEvaluationFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                QualityEvaluation qualityEvaluation;
                if ((bool)model.PishOk)
                {
                    qualityEvaluation = new QualityEvaluation
                    {
                        HrWork = model.HrWork,
                        PishOk=model.PishOk,
                        K1=model.K1,
                        K2=model.K2,
                        K3=model.K3,
                        K4=model.K4,
                        K5=model.K5,
                        K6=model.K6,
                        K7=model.K7,
                        K8=model.K8,
                        Quality=model.Quality,
                    };
                }
                else
                {
                    qualityEvaluation = new QualityEvaluation
                    {
                        HrWork = model.HrWork,
                        PishOk = model.PishOk,
                        Quality = model.Quality,
                        RejectReason=model.RejectReason
                    };
                }


                int senderID = _uw.UserRepository.Get(u=>u.Username==User.Identity.Name).Select(u=>u.ID).SingleOrDefault();
                int secretaryID = _uw.UserRoleRepository.Get(ur =>ur.RoleID==1)
                                                            .Select(ur=>ur.UserID)
                                                            .FirstOrDefault();//secretary
                Referral referral = _uw.ReferralRepository.Get(r=>r.ID==model.ReferralID,include:s=>s
                                                                            .Include(r=>r.Proposal))
                                                                            .SingleOrDefault();
                Proposal proposal = referral.Proposal;
                Referral newReferral = new Referral()
                {
                    QualityEvaluation = qualityEvaluation,
                    SenderID = senderID,
                    ReciverID = secretaryID,
                    ProposalID = referral.ProposalID,
                    StatusID = 2,
                    EvaluationTypeID = 2,
                    Date = _utilities.GetDate(),
                    IP = _utilities.GetUSRIP(HttpContext),
                    Time = _utilities.GetTime(),
                    Description = "انجام ارزیابی",
                    Result = ((bool)model.PishOk ? "پیشنهاد مورد تایید میباشد" : "پیشنهاد مورد تایید نمیباشد"),
                };
                referral.StatusID = 3;//ارزیابی شده
                proposal.StatusID = 6;//عودت از ارزیابی به دبیرخانه
                _uw.ReferralRepository.Create(newReferral);
                _uw.ReferralRepository.Update(referral);
                _uw.ProposalRepository.Update(proposal);
                await _uw.SaveChangesAsync();
                return RedirectToAction("SuccessOperation","Messages");

            }
            return View(model);
        }
    }
}
