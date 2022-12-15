using EESV2.DAL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EESV2.DAL.Entities;
using EESV2.DAL.ViewModels;
using EESV2.DAL.ViewModels.TopMemberReport;
using Microsoft.EntityFrameworkCore;

namespace EESV2.DAL.Services
{
    public class RankService : IRankService
    {
        private EESContext _context;

        public RankService(EESContext context)
        {
            _context = context;
        }

        #region Rank Calculator

        public List<UserRankViewModel> RankCalculation()
        {
            IQueryable<User> query = _context.Users;

            List<User> users = query
                .Include(u => u.Office)
                .Include(u => u.Proposals)
                .ThenInclude(p => p.Referrals)
                .Include(u => u.Proposals)
                .ThenInclude(p => p.Imparts)
                .ThenInclude(p => p.Reports)
                .ToList();

            //get users for participant
            var users2 = query
                .Include(p => p.ProposalsThatHelped).ToList();

            List<UserRankViewModel> userRankViewModels = new List<UserRankViewModel>();

            //Calculate the score of proposal
            userRankViewModels = CalculatedScoreOfProposal(users);

            //Calculate the score of participant proposal
            userRankViewModels = CalculatedScoreOfParticipantProposal(users2, userRankViewModels);

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

        public List<UserRankViewModel> RankCalculation(List<int> officeIDs, int year, int month)
        {
            IQueryable<User> query = _context.Users;

            List<User> users = query
                .Where(u => officeIDs.Contains((int)u.OfficeID))
                .Include(u => u.Office)
                .Include(u => u.Proposals.Where(p => EF.Functions.Like(p.Date, (year != 0 ? year : "%") + "/" + (month != 0 ? month.ToString("0#") : "%") + "/%")))
                .ThenInclude(p => p.Referrals)
                .Include(u => u.Proposals.Where(p => EF.Functions.Like(p.Date, (year != 0 ? year : "%") + "/" + (month != 0 ? month.ToString("0#") : "%") + "/%")))
                .ThenInclude(p => p.Imparts)
                .ThenInclude(p => p.Reports)
                .ToList();

            //get users for participant
            var users2 = query
                .Where(u => officeIDs.Contains((int)u.OfficeID))
                .Include(p => p.ProposalsThatHelped
                    .Where(p => EF.Functions.Like(p.Proposal.Date, (year != 0 ? year : "%") + "/" + (month != 0 ? month.ToString("0#") : "%") + "/%")))
                .ToList();

            List<UserRankViewModel> userRankViewModels = new List<UserRankViewModel>();

            //Calculate the score of proposal
            userRankViewModels = CalculatedScoreOfProposal(users);

            //Calculate the score of participant proposal
            userRankViewModels = CalculatedScoreOfParticipantProposal(users2, userRankViewModels);

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

        public List<UserRankViewModel> TopMembersRankCalculation(TopMemberViewModel model)
        {
            IQueryable<User> query = _context.Users;

            List<User> users = query
                .Where(u => model.OfficeIDs.Contains((int)u.OfficeID))
                .Include(u => u.Office)
                .Include(u => u.Proposals.Where(p => EF.Functions.Like(p.Date, (model.getYear() != 0 ? model.getYear() : "%") + "/" + (model.getMonth() != 0 ? model.getMonth().ToString("0#") : "%") + "/%")))
                .ThenInclude(p => p.Referrals)
                .Include(u => u.Proposals.Where(p => EF.Functions.Like(p.Date, (model.getYear() != 0 ? model.getYear() : "%") + "/" + (model.getMonth() != 0 ? model.getMonth().ToString("0#") : "%") + "/%")))
                .ThenInclude(p => p.Imparts)
                .ThenInclude(p => p.Reports)
                .ToList();

            //get users for participant
            var users2 = query
                .Include(p => p.ProposalsThatHelped.Where(p => EF.Functions.Like(p.Proposal.Date,
                    (model.getYear() != 0 ? model.getYear() : "%") + "/" +
                    (model.getMonth() != 0 ? model.getMonth().ToString("0#") : "%") + "/%")))
                .ThenInclude(p => p.Proposal)
                .ThenInclude(p => p.Referrals)
                .Include(p => p.ProposalsThatHelped.Where(p => EF.Functions.Like(p.Proposal.Date,
                    (model.getYear() != 0 ? model.getYear() : "%") + "/" +
                    (model.getMonth() != 0 ? model.getMonth().ToString("0#") : "%") + "/%")))
                .ThenInclude(p => p.Proposal)
                .ThenInclude(p => p.Imparts)
                .ThenInclude(p => p.Reports)
                .ToList();

            model.userRankViewModels = new List<UserRankViewModel>();

            //Calculate the score of proposal
            foreach (var user in users)
            {
                #region Proposal

                int q1 = user.Proposals.Count(p => p.StatusID != 3);//تعداد پیشنهادات رد نشده کاربر

                List<Proposal> p1 = user.Proposals.Where(p =>
                    p.StatusID == 9 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();// پیشنهاداتی که به واحد مجری ارسال شده اند و تصویب شده کمی هستند

                List<Proposal> p2 = user.Proposals.Where(p =>
                    p.StatusID == 9 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();// پیشنهاداتی که به واحد مجری ارسال شده اند و تصویب شده کیفی هستند

                List<Proposal> p3 = user.Proposals.Where(p =>
                    p.StatusID == 5 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList(); // پیشنهاداتی که اجرا شده کمی هستند

                List<Proposal> p4 = user.Proposals.Where(p =>
                    p.StatusID == 5 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList(); // پیشنهاداتی که اجرا شده کیفی هستند

                var q6 = user.Proposals.Where(p =>
                    p.StatusID == 2 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList(); //تعداد پیشنهادات که تصویب کمی شده اند ولی هنوز به واحد مجری ارسل نشده اند

                var q7 = user.Proposals.Where(p =>
                    p.StatusID == 2 && p.Referrals.Count > 0 &&
                    p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList(); //تعداد پیشنهادات که تصویب کیفی شده اند ولی هنوز به واحد مجری ارسل نشده اند

                double score = (q1 > 30 ? 30 : q1) + (q6.Count * 30 + q7.Count * 10);

                foreach (var p in p1)
                {
                    //درصد پیشرفت کار
                    //double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                    //درصد مشارکت
                    //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = /*participationPercentage **/ 60 /** workProgress*/;

                    score += a;
                }

                foreach (var p in p2)
                {
                    //درصد پیشرفت کار
                    //double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                    //درصد مشارکت
                    //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = /*participationPercentage **/ 20 /** workProgress*/;

                    score += a;
                }

                foreach (var p in p3)
                {
                    //درصد پیشرفت کار
                    double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                    //درصد مشارکت
                    //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = /*participationPercentage **/ 60 * workProgress;

                    score += a;
                }

                foreach (var p in p4)
                {
                    //درصد پیشرفت کار
                    double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                    //درصد مشارکت
                    //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = /*participationPercentage **/ 20 * workProgress;

                    score += a;
                }

                foreach (var p in q6)
                {
                    //درصد مشارکت
                    //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = /*participationPercentage **/ 30;

                    score += a;
                }

                foreach (var p in q7)
                {
                    //درصد مشارکت
                    //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = /*participationPercentage **/ 10;

                    score += a;
                }

                #endregion

                UserRankViewModel temp = new UserRankViewModel()
                {
                    ID = user.ID,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PersonnelCode = user.Username,
                    Office = user.Office.Name,
                    ProposalCount = user.Proposals.Count,
                    Score = (int)Math.Round(score, 0),
                    Rank = 1,
                    ParticipantProposal = user.ProposalsThatHelped.Count
                };
                model.userRankViewModels.Add(temp);
            }

            //Calculate the score of participant proposal
            foreach (var user in users2)
            {
                #region Participant Proposal

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

                var qp6 = user.ProposalsThatHelped.Select(p =>
                    p.Proposal).Where(p => p.StatusID == 2 && p.Referrals.Count > 0 &&
                                           p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();//تعداد پیشنهادات گروهی که تصویب کمی شده اند ولی هنوز به واحد مجری ارسال نشده اند

                var qp7 = user.ProposalsThatHelped.Select(p =>
                    p.Proposal).Where(p => p.StatusID == 2 && p.Referrals.Count > 0 &&
                                           p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();//تعداد پیشنهادات گروهی ای که تصویب کیفی شده اند ولی هنوز به واحد مجری ارسال نشده اند

                double score = 0;

                foreach (var p in qp1)
                {
                    //درصد پیشرفت کار
                    //double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                    //درصد مشارکت
                    double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = participationPercentage * 60 /** workProgress*/;

                    score += a;
                }

                foreach (var p in qp2)
                {
                    //درصد پیشرفت کار
                    //double workProgress = (double)(ProgressCalculation(p.ID) / 100.0);

                    //درصد مشارکت
                    double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = participationPercentage * 20/* * workProgress*/;

                    score += a;
                }

                foreach (var p in qp3)
                {
                    //درصد پیشرفت کار
                    double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                    //درصد مشارکت
                    double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = participationPercentage * 60 * workProgress;

                    score += a;
                }

                foreach (var p in qp4)
                {
                    //درصد پیشرفت کار
                    double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                    //درصد مشارکت
                    double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = participationPercentage * 20 * workProgress;

                    score += a;
                }

                foreach (var p in qp6)
                {
                    //درصد مشارکت
                    double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = participationPercentage * 30;

                    score += a;
                }

                foreach (var p in qp7)
                {
                    //درصد مشارکت
                    double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                    double a = participationPercentage * 10;

                    score += a;
                }

                #endregion

                //get user of user rank list
                UserRankViewModel modell = model.userRankViewModels.SingleOrDefault(p => p.ID == user.ID);

                if (modell != null)
                {
                    //making new model and update score
                    UserRankViewModel temp = new UserRankViewModel()
                    {
                        ID = modell.ID,
                        FirstName = modell.FirstName,
                        LastName = modell.LastName,
                        PersonnelCode = modell.PersonnelCode,
                        Office = modell.Office,
                        ProposalCount = modell.ProposalCount,
                        Rank = modell.Rank,
                        Score = (int)Math.Round(score, 0) + modell.Score,
                        ParticipantProposal =  modell.ParticipantProposal
                    };

                    //remove old model
                    model.userRankViewModels.Remove(modell);

                    //add new model
                    model.userRankViewModels.Add(temp);
                }
            }

            model.userRankViewModels = model.userRankViewModels.OrderByDescending(v => v.Score).ToList();
            for (int i = 1; i < model.userRankViewModels.Count; i++)
            {
                if (model.userRankViewModels[i].Score == model.userRankViewModels[i - 1].Score)
                {
                    model.userRankViewModels[i].Rank = model.userRankViewModels[i - 1].Rank;
                }
                else
                {
                    model.userRankViewModels[i].Rank = model.userRankViewModels[i - 1].Rank + 1;
                }
            }

            return model.userRankViewModels;
        }

        public List<UserRankViewModel> CalculatedScoreOfProposal(List<User> users)
        {
            List<UserRankViewModel> userRankViewModels = new List<UserRankViewModel>();

            if (users != null)
            {
                foreach (var user in users)
                {
                    #region Proposal

                    int q1 = user.Proposals.Count(p => p.StatusID != 3);//تعداد پیشنهادات رد نشده کاربر

                    List<Proposal> p1 = user.Proposals.Where(p =>
                        p.StatusID == 9 && p.Referrals.Count > 0 &&
                        p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();// پیشنهاداتی که به واحد مجری ارسال شده اند و تصویب شده کمی هستند

                    List<Proposal> p2 = user.Proposals.Where(p =>
                        p.StatusID == 9 && p.Referrals.Count > 0 &&
                        p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();// پیشنهاداتی که به واحد مجری ارسال شده اند و تصویب شده کیفی هستند

                    List<Proposal> p3 = user.Proposals.Where(p =>
                        p.StatusID == 5 && p.Referrals.Count > 0 &&
                        p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList(); // پیشنهاداتی که اجرا شده کمی هستند

                    List<Proposal> p4 = user.Proposals.Where(p =>
                        p.StatusID == 5 && p.Referrals.Count > 0 &&
                        p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList(); // پیشنهاداتی که اجرا شده کیفی هستند

                    var q6 = user.Proposals.Where(p =>
                        p.StatusID == 2 && p.Referrals.Count > 0 &&
                        p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList(); //تعداد پیشنهادات که تصویب کمی شده اند ولی هنوز به واحد مجری ارسل نشده اند

                    var q7 = user.Proposals.Where(p =>
                        p.StatusID == 2 && p.Referrals.Count > 0 &&
                        p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList(); //تعداد پیشنهادات که تصویب کیفی شده اند ولی هنوز به واحد مجری ارسل نشده اند

                    double score = (q1 > 30 ? 30 : q1) + (q6.Count * 30 + q7.Count * 10);

                    foreach (var p in p1)
                    {
                        //درصد پیشرفت کار
                        //double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                        //درصد مشارکت
                        //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = /*participationPercentage **/ 60 /** workProgress*/;

                        score += a;
                    }

                    foreach (var p in p2)
                    {
                        //درصد پیشرفت کار
                        //double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                        //درصد مشارکت
                        //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = /*participationPercentage **/ 20 /** workProgress*/;

                        score += a;
                    }

                    foreach (var p in p3)
                    {
                        //درصد پیشرفت کار
                        double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                        //درصد مشارکت
                        //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = /*participationPercentage **/ 60 * workProgress;

                        score += a;
                    }

                    foreach (var p in p4)
                    {
                        //درصد پیشرفت کار
                        double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                        //درصد مشارکت
                        //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = /*participationPercentage **/ 20 * workProgress;

                        score += a;
                    }

                    foreach (var p in q6)
                    {
                        //درصد مشارکت
                        //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = /*participationPercentage **/ 30;

                        score += a;
                    }

                    foreach (var p in q7)
                    {
                        //درصد مشارکت
                        //double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = /*participationPercentage **/ 10;

                        score += a;
                    }

                    #endregion

                    UserRankViewModel temp = new UserRankViewModel()
                    {
                        ID = user.ID,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        PersonnelCode = user.Username,
                        Office = user.Office.Name,
                        ProposalCount = user.Proposals.Count,
                        Score = (int)Math.Round(score, 0),
                        Rank = 1
                    };
                    userRankViewModels.Add(temp);
                }
            }

            return userRankViewModels;
        }

        public List<UserRankViewModel> CalculatedScoreOfParticipantProposal(List<User> users2,List<UserRankViewModel> userRankViewModels)
        {
            if (users2!=null && userRankViewModels != null)
            {
                foreach (var user in users2)
                {
                    #region Participant Proposal

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

                    var qp6 = user.ProposalsThatHelped.Select(p =>
                        p.Proposal).Where(p => p.StatusID == 2 && p.Referrals.Count > 0 &&
                                               p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 1).ToList();//تعداد پیشنهادات گروهی که تصویب کمی شده اند ولی هنوز به واحد مجری ارسال نشده اند

                    var qp7 = user.ProposalsThatHelped.Select(p =>
                        p.Proposal).Where(p => p.StatusID == 2 && p.Referrals.Count > 0 &&
                                               p.Referrals.OrderBy(r => r.ID).LastOrDefault().EvaluationTypeID == 2).ToList();//تعداد پیشنهادات گروهی ای که تصویب کیفی شده اند ولی هنوز به واحد مجری ارسال نشده اند

                    double score = 0;

                    foreach (var p in qp1)
                    {
                        //درصد پیشرفت کار
                        //double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                        //درصد مشارکت
                        double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = participationPercentage * 60 /** workProgress*/;

                        score += a;
                    }

                    foreach (var p in qp2)
                    {
                        //درصد پیشرفت کار
                        //double workProgress = (double)(ProgressCalculation(p.ID) / 100.0);

                        //درصد مشارکت
                        double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = participationPercentage * 20/* * workProgress*/;

                        score += a;
                    }

                    foreach (var p in qp3)
                    {
                        //درصد پیشرفت کار
                        double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                        //درصد مشارکت
                        double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = participationPercentage * 60 * workProgress;

                        score += a;
                    }

                    foreach (var p in qp4)
                    {
                        //درصد پیشرفت کار
                        double workProgress = (double)(ProgressCalculation(p.ID)) / 100.0;

                        //درصد مشارکت
                        double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = participationPercentage * 20 * workProgress;

                        score += a;
                    }

                    foreach (var p in qp6)
                    {
                        //درصد مشارکت
                        double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = participationPercentage * 30;

                        score += a;
                    }

                    foreach (var p in qp7)
                    {
                        //درصد مشارکت
                        double participationPercentage = (double)p.RegistrarParticipatePercent / 100.0;

                        double a = participationPercentage * 10;

                        score += a;
                    }

                    #endregion

                    //get user of user rank list
                    UserRankViewModel model = userRankViewModels.FirstOrDefault(p => p.ID == user.ID);

                    //making new model and update score
                    UserRankViewModel temp = new UserRankViewModel()
                    {
                        ID = model.ID,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        PersonnelCode = model.PersonnelCode,
                        Office = model.Office,
                        ProposalCount = model.ProposalCount,
                        Rank = model.Rank,
                        Score = (int)Math.Round(score, 0) + model.Score,
                    };

                    //remove old model
                    userRankViewModels.Remove(model);

                    //add new model
                    userRankViewModels.Add(temp);


                }
            }

            return userRankViewModels;
        }

        #endregion

        #region Progress Calculation

        public double ProgressCalculation(int proposalId)
        {
            _context.Database.CloseConnection();

            _context.Database.OpenConnection();

            var imparts = _context.Imparts
                .Where(i => i.ProposalID == proposalId)
                .Include(i => i.Reports)
                .ToList();

            _context.Database.CloseConnection();

            _context.Database.OpenConnection();

            if (imparts != null)
            {
                double percent = 0;

                foreach (var impart in imparts)
                {
                    percent += impart.Reports.Sum(r => r.Percentage);
                }

                return percent / imparts.Count;
            }

            return 0;
        }

        #endregion
    }
}
