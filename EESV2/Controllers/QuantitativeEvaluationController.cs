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
    public class QuantitativeEvaluationController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IUtilities _utilities;
        IProposalRepository _proposalRepository;
        public QuantitativeEvaluationController(
            IUnitOfWork uw,
            IUtilities utilities,
            IProposalRepository proposalRepository
            )
        {
            _uw = uw;
            _utilities = utilities;
            _proposalRepository = proposalRepository;
        }

        public IActionResult Form(int referralID)
        {
            ViewData["ReferralID"] = referralID;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Form(QuantitativeEvaluationFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                QuantitativEvaluation quantitativEvaluation = new QuantitativEvaluation()
                {
                    DateArz = _utilities.GetDate(),
                    Q1 = model.Q1,
                    Q2 = model.Q2,
                    Q3 = model.Q3,
                    Q4 = model.Q4,
                    Q5 = model.Q5,
                    Q6 = model.Q6,
                    Q7 = model.Q7,
                    Q8 = model.Q8,
                    Q9 = model.Q9,
                    Q10 = model.Q10,
                    Ejra5Year = model.Ejra5Year,
                    EjraYear = model.EjraYear,
                    EjraMonth = model.EjraMonth,
                    ErjraDaily = model.ErjraDaily,
                    Sama5Year = model.Sama5Year,
                    SamarYear = model.SamarYear,
                    SamarMonth = model.SamarMonth,
                    SamarDaily = model.SamarDaily,
                    Sarfe5Year = model.Sarfe5Year,
                    SarfeYear = model.SarfeYear,
                    SarfeMonth = model.SarfeMonth,
                    SarfeDaily = model.SarfeDaily,
                    HrWork = model.HrWork,
                    MablaghNahaiAlphabet = model.MablaghNahaiAlphabet,
                    MablaghNahaiNumber = model.MablaghNahaiNumber,
                    PishOk = model.PishOk,
                    Quality = model.Quality
                };



                int senderID = _uw.UserRepository.Get(u => u.Username == User.Identity.Name).Select(u => u.ID).SingleOrDefault();
                int secretaryID = _uw.UserRoleRepository.Get(ur => ur.RoleID == 1)
                                                            .Select(ur => ur.UserID)
                                                            .FirstOrDefault();//secretary
                Referral referral = _uw.ReferralRepository.Get(r => r.ID == model.ReferralID, include: s => s
                                                                            .Include(r => r.Proposal))
                                                                            .SingleOrDefault();
                Proposal proposal = referral.Proposal;
                Referral newReferral = new Referral()
                {
                    QuantitativEvaluation = quantitativEvaluation,
                    SenderID = senderID,
                    ReciverID = secretaryID,
                    ProposalID = referral.ProposalID,
                    StatusID = 2,
                    EvaluationTypeID = 1,
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
                return RedirectToAction("SuccessOperation", "Messages");

                // خطا در ذخیره
            }
            return View(model);
        }
    }
}
