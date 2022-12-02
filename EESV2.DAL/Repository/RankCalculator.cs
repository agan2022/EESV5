using EESV2.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EESV2.DAL.ViewModels;
using EESV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EESV2.DAL.Repository
{
    public class RankCalculator : IRankCalculator
    {
        private readonly EESContext _context;
        private readonly IDarsadPishraftCalculator _darsadPishraftCalculator;
        public RankCalculator(EESContext context,IDarsadPishraftCalculator darsadPishraftCalculator)
        {
            _context = context;
            _darsadPishraftCalculator = darsadPishraftCalculator;
        }
        public List<UserRankViewModel> CalculateRank(List<int> officeIDs,int year,int month)
        {
            List<User> users=_context.Users.Where(u=>officeIDs.Contains((int)u.OfficeID))
                                                .Include(u => u.Office)
                                                .Include(u => u.Proposals.Where(p => EF.Functions.Like(p.Date, (year != 0 ? year : "%") + "/" + (month != 0 ? month.ToString("0#") : "%") + "/%")))
                                                .ThenInclude(p => p.Referrals)
                                                .Include(u => u.Proposals.Where(p => EF.Functions.Like(p.Date, (year != 0 ? year : "%") + "/" + (month != 0 ? month.ToString("0#") : "%") + "/%")))
                                                .ThenInclude(p => p.Imparts)
                                                .ThenInclude(p => p.Reports)
                                                .Include(p=> p.ProposalsThatHelped)
                                                .ThenInclude(p=> p.Proposal)
                                                .ToList();

            List<UserRankViewModel> userRankViewModels = new List<UserRankViewModel>();
            foreach (User user in users)
            {
                int q1 = user.Proposals.Where(p => p.StatusID != 3).Count();//تعداد پیشنهادات رد نشده کاربر
                List<Proposal> p1 = user.Proposals.Where(p => p.StatusID == 9 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();// پیشنهاداتی که به واحد مجری ارسال شده اند و تصویب شده کمی هستند
                List<Proposal> p2 = user.Proposals.Where(p => p.StatusID == 9 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();// پیشنهاداتی که به واحد مجری ارسال شده اند و تصویب شده کیفی هستند
                List<Proposal> p3 = user.Proposals.Where(p => p.StatusID == 5 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();// پیشنهاداتی که اجرا شده کمی هستند
                List<Proposal> p4 = user.Proposals.Where(p => p.StatusID == 5 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();// پیشنهاداتی که اجرا شده کیفی هستند
                int q6 = user.Proposals.Where(p => p.StatusID == 2 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).Count();//تعداد پیشنهادات که تصویب کمی شده اند ولی هنوز به واحد مجری ارسل نشده اند
                int q7 = user.Proposals.Where(p => p.StatusID == 2 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).Count();//تعداد پیشنهادات که تصویب کیفی شده اند ولی هنوز به واحد مجری ارسل نشده اند

                #region Participant Proposal

                int qqp1 = user.ProposalsThatHelped
                   .Select(p => p.Proposal).Count(p => p.StatusID != 3);//تعداد پیشنهادات رد نشده گروهی کاربر

                var qp1 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 9 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();//پیشنهادات گروهی که به واحد مجری ارسال شده اند و تصویب شده کمی هستند

                var qp2 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 9 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();//پیشنهادات گروهی که به واحد مجری ارسال شده اند و تصویب شده کیفی هستند

                var qp3 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 5 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();// پیشنهادات گروهی ای که اجرا شده کمی هستند

                var qp4 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 5 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();//پیشنهادات گروهی که اجرا شده کیفی هستند

                int qp6 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 2 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).Count();//تعداد پیشنهادات گروهی که تصویب کمی شده اند ولی هنوز به واحد مجری ارسال نشده اند

                int qp7 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 2 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).Count();//تعداد پیشنهادات گروهی ای که تصویب کیفی شده اند ولی هنوز به واحد مجری ارسال نشده اند

                #endregion


                int score = (q1 > 30 ? 30 : q1) + (q6 * 30 + q7 * 10) + (qqp1 > 30 ? 30 : qqp1) + (qp6 * 30 + qp7 * 10);

                foreach (Proposal p in p1)
                {
                    score += 60 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                //Participant
                foreach (Proposal p in qp1)
                {
                    score += 60 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                foreach (Proposal p in p2)
                {
                    score += 20 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                //Participant
                foreach (Proposal p in qp2)
                {
                    score += 20 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                foreach (Proposal p in p3)
                {
                    score += 60 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                //Participant
                foreach (Proposal p in qp3)
                {
                    score += 60 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                foreach (Proposal p in p4)
                {
                    score += 20 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                //Participant
                foreach (Proposal p in qp4)
                {
                    score += 20 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
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
                userRankViewModels.Add(temp);
            }
            userRankViewModels = userRankViewModels.OrderByDescending(v => v.Score).ToList();
            for (int i = 1; i < userRankViewModels.Count; i++)
            {
                if (userRankViewModels[i].Score == userRankViewModels[i - 1].Score)
                {
                    userRankViewModels[i].Rank = userRankViewModels[i - 1].Rank;
                }
                else
                {
                    userRankViewModels[i].Rank = userRankViewModels[i - 1].Rank + 1;
                }
            }
            return userRankViewModels;
        }

        public List<UserRankViewModel> CalculateRank()
        {
            List<User> users = _context.Users
                                .Include(u => u.Office)
                                .Include(u => u.Proposals)
                                .ThenInclude(p => p.Referrals)
                                .Include(u => u.Proposals)
                                .ThenInclude(p => p.Imparts)
                                .ThenInclude(p => p.Reports)
                                .Include(p=> p.ProposalsThatHelped)
                                .ThenInclude(p=> p.Proposal)
                                .ToList();

            List<UserRankViewModel> userRankViewModels = new List<UserRankViewModel>();
            foreach (User user in users)
            {
                int q1 = user.Proposals.Where(p => p.StatusID != 3).Count();//تعداد پیشنهادات رد نشده کاربر
                List<Proposal> p1 = user.Proposals.Where(p => p.StatusID == 9 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();// پیشنهاداتی که به واحد مجری ارسال شده اند و تصویب شده کمی هستند
                List<Proposal> p2 = user.Proposals.Where(p => p.StatusID == 9 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();// پیشنهاداتی که به واحد مجری ارسال شده اند و تصویب شده کیفی هستند
                List<Proposal> p3 = user.Proposals.Where(p => p.StatusID == 5 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();// پیشنهاداتی که اجرا شده کمی هستند
                List<Proposal> p4 = user.Proposals.Where(p => p.StatusID == 5 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();// پیشنهاداتی که اجرا شده کیفی هستند
                int q6 = user.Proposals.Where(p => p.StatusID == 2 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).Count();//تعداد پیشنهادات که تصویب کمی شده اند ولی هنوز به واحد مجری ارسل نشده اند
                int q7 = user.Proposals.Where(p => p.StatusID == 2 && p.Referrals.Count > 0 && p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).Count();//تعداد پیشنهادات که تصویب کیفی شده اند ولی هنوز به واحد مجری ارسل نشده اند

                #region Participant Proposal

                int qqp1 = user.ProposalsThatHelped
                   .Select(p => p.Proposal).Count(p => p.StatusID != 3);//تعداد پیشنهادات رد نشده گروهی کاربر

                var qp1 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 9 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();//پیشنهادات گروهی که به واحد مجری ارسال شده اند و تصویب شده کمی هستند

                var qp2 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 9 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();//پیشنهادات گروهی که به واحد مجری ارسال شده اند و تصویب شده کیفی هستند

                var qp3 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 5 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();// پیشنهادات گروهی ای که اجرا شده کمی هستند

                var qp4 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 5 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();//پیشنهادات گروهی که اجرا شده کیفی هستند

                int qp6 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 2 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).Count();//تعداد پیشنهادات گروهی که تصویب کمی شده اند ولی هنوز به واحد مجری ارسال نشده اند

                int qp7 = user.ProposalsThatHelped.Select(p => p.Proposal).Where(p =>
                    p.StatusID == 2 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).Count();//تعداد پیشنهادات گروهی ای که تصویب کیفی شده اند ولی هنوز به واحد مجری ارسال نشده اند

                #endregion


                int score = (q1 > 30 ? 30 : q1) + (q6 * 30 + q7 * 10) + (qqp1 > 30 ? 30 : qqp1) + (qp6 * 30 + qp7 * 10);

                foreach (Proposal p in p1)
                {
                    score += 60 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                //Participant
                foreach (Proposal p in qp1)
                {
                    score += 60 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                foreach (Proposal p in p2)
                {
                    score += 20 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                //Participant
                foreach (Proposal p in qp2)
                {
                    score += 20 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                foreach (Proposal p in p3)
                {
                    score += 60 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                //Participant
                foreach (Proposal p in qp3)
                {
                    score += 60 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                foreach (Proposal p in p4)
                {
                    score += 20 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                //Participant
                foreach (Proposal p in qp4)
                {
                    score += 20 * _darsadPishraftCalculator.CalculateDarsadPishraft(p.ID) / 100;
                }

                UserRankViewModel temp = new UserRankViewModel()
                {
                    ID=user.ID,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PersonnelCode = user.Username,
                    Office = user.Office.Name,
                    ProposalCount = user.Proposals.Count,
                    Score = score,
                    Rank = 1
                };
                userRankViewModels.Add(temp);
            }
            userRankViewModels=userRankViewModels.OrderByDescending(v => v.Score).ToList();
            for (int i = 1; i < userRankViewModels.Count; i++)
            {
                if (userRankViewModels[i].Score == userRankViewModels[i - 1].Score)
                {
                    userRankViewModels[i].Rank = userRankViewModels[i - 1].Rank;
                }
                else
                {
                    userRankViewModels[i].Rank = userRankViewModels[i - 1].Rank + 1;
                }
            }
            return userRankViewModels;
        }
    }
}
