using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels.TopMemberReport;
using EESV2.DAL.ViewModels;
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
    public class TopMemberReportController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IProposalRepository _proposalRepository;
        public TopMemberReportController(IUnitOfWork uw,IProposalRepository proposalRepository)
        {
            _uw = uw;
            _proposalRepository = proposalRepository;
        }

        [HttpGet]
        public IActionResult TopMembers()
        {
            return View();
        }
            [HttpPost]
        public IActionResult TopMembers(TopMemberViewModel model)
        {
            if (ModelState.IsValid)
            {
                List<User> users = _uw.UserRepository.Get(u=>model.OfficeIDs.Contains((int)u.OfficeID),include:s=>s
                                                            .Include(u=>u.Office)
                                                            .Include(u=>u.Proposals.Where(p =>EF.Functions.Like(p.Date, (model.getYear() != 0 ? model.getYear() : "%") + "/" + (model.getMonth() != 0 ? model.getMonth().ToString("0#") : "%") + "/%")))
                                                            .ThenInclude(p=>p.Referrals)
                                                            .Include(u => u.Proposals.Where(p => EF.Functions.Like(p.Date, (model.getYear() != 0 ? model.getYear() : "%") + "/" + (model.getMonth() != 0 ? model.getMonth().ToString("0#") : "%") + "/%")))
                                                            .ThenInclude(p => p.Imparts)
                                                            .ThenInclude(p => p.Reports))
                                                            .ToList();

                model.userRankViewModels = new List<UserRankViewModel>();
                foreach (User user in users)
                {
                    int q1 = user.Proposals.Where(p => p.StatusID != 3).Count();//تعداد پیشنهادات رد نشده کاربر
                    List<Proposal> p1 = user.Proposals.Where(p => p.StatusID == 9 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList() ;// پیشنهاداتی که به واحد مجری ارسال شده اند و تصویب شده کمی هستند
                    List<Proposal> p2 = user.Proposals.Where(p => p.StatusID == 9 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();// پیشنهاداتی که به واحد مجری ارسال شده اند و تصویب شده کیفی هستند
                    List<Proposal> p3 = user.Proposals.Where(p => p.StatusID == 5 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();// پیشنهاداتی که اجرا شده کمی هستند
                    List<Proposal> p4 = user.Proposals.Where(p => p.StatusID == 5 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();// پیشنهاداتی که اجرا شده کیفی هستند
                    int q6 = user.Proposals.Where(p => p.StatusID == 2 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).Count();//تعداد پیشنهادات که تصویب کمی شده اند ولی هنوز به واحد مجری ارسل نشده اند
                    int q7 = user.Proposals.Where(p => p.StatusID == 2 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).Count();//تعداد پیشنهادات که تصویب کیفی شده اند ولی هنوز به واحد مجری ارسل نشده اند

                    int score = (q1 > 30 ? 30 : q1)+(q6 * 30 + q7 * 10);
                    foreach (Proposal p in p1)
                    {
                        score += 60 * _proposalRepository.CalculateDarsadPishraft(p) / 100;
                    }
                    foreach (Proposal p in p2)
                    {
                        score += 20 * _proposalRepository.CalculateDarsadPishraft(p) / 100;
                    }
                    foreach (Proposal p in p3)
                    {
                        score += 60 * _proposalRepository.CalculateDarsadPishraft(p) / 100;
                    }
                    foreach (Proposal p in p4)
                    {
                        score += 20 * _proposalRepository.CalculateDarsadPishraft(p) / 100;
                    }
                    UserRankViewModel temp = new UserRankViewModel()
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        PersonnelCode = user.Username,
                        Office = user.Office.Name,
                        ProposalCount = user.Proposals.Count,
                        Score = score,
                        Rank = 1
                    };
                    model.userRankViewModels.Add(temp);
                }
                model.userRankViewModels = model.userRankViewModels.OrderByDescending(v => v.Score).ToList();
                for (int i = 1; i < model.userRankViewModels.Count; i++)
                {
                    if (model.userRankViewModels[i].Score== model.userRankViewModels[i-1].Score)
                    {
                        model.userRankViewModels[i].Rank = model.userRankViewModels[i - 1].Rank;
                    }
                    else
                    {
                        model.userRankViewModels[i].Rank = model.userRankViewModels[i - 1].Rank+1;
                    }
                }
                ViewData["viewModel"] = model.userRankViewModels;
            }
            return View(model);
        }
    }
}
