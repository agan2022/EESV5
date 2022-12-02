using EESV2.DAL.Entities;
using EESV2.DAL.Repository;
using EESV2.DAL.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class ProposalRepository : IProposalRepository
    {
        EESContext _context;
        public ProposalRepository(EESContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewProposal(NewProposalViewModel model)
        {
            if (model.Ch01 == null) model.Ch01 = false;
            if (model.Ch02 == null) model.Ch02 = false;
            if (model.Ch03 == null) model.Ch03 = false;
            if (model.Ch04 == null) model.Ch04 = false;
            if (model.Ch05 == null) model.Ch05 = false;
            if (model.Ch06 == null) model.Ch06 = false;
            if (model.Ch07 == null) model.Ch07 = false;
            if (model.Ch08 == null) model.Ch08 = false;
            if (model.Ch09 == null) model.Ch09 = false;
            if (model.Ch10 == null) model.Ch10 = false;
            if (model.Ch11 == null) model.Ch11 = false;
            if (model.Ch12 == null) model.Ch12 = false;
            if (model.Ch13 == null) model.Ch13 = false;
            if (model.Ch14 == null) model.Ch14 = false;
            if (model.Ch15 == null) model.Ch15 = false;
            if (model.Ch16 == null) model.Ch16 = false;
            if (model.Ch17 == null) model.Ch17 = false;
            if (model.Ch18 == null) model.Ch18 = false;
            if (model.Ch19 == null) model.Ch19 = false;
            if (model.Ch20 == null) model.Ch20 = false;
            if (model.Ch21 == null) model.Ch21 = false;
            if (model.Ch22 == null) model.Ch22 = false;
            if (model.Ch23 == null) model.Ch23 = false;
            if (model.Ch24 == null) model.Ch24 = false;
            if (model.Ch25 == null) model.Ch25 = false;
            if (model.Ch26 == null) model.Ch26 = false;
            if (model.Ch27 == null) model.Ch27 = false;
            if (model.Ch28 == null) model.Ch28 = false;
            if (model.Ch29 == null) model.Ch29 = false;
            if (model.Ch30 == null) model.Ch30 = false;
            if (model.Ch31 == null) model.Ch31 = false;
            if (model.Ch32 == null) model.Ch32 = false;
            if (model.Ch33 == null) model.Ch33 = false;
            if (model.Ch34 == null) model.Ch34 = false;
            if (model.Ch35 == null) model.Ch35 = false;
            if (model.Ch36 == null) model.Ch36 = false;
            if (model.Ch37 == null) model.Ch37 = false;
            Proposal proposal = new Proposal()
            {
                SubjectPr = model.SubjectPr,
                CodeBazr = model.CodeBazr,
                CurrentDescPr = model.CurrentDescPr,
                NewDesPr = model.NewDesPr,
                Date = model.Date,
                Time = model.Time,
                IP = model.IP,
                File = model.file,
                StatusID = 4,
                DesDabir = model.DesDabir,
                EjraDaily = model.EjraDaily.ToString(),
                EjraMonthly = model.EjraMonthly.ToString(),
                EjraYear = model.EjraYear.ToString(),
                Ejra5Year = model.Ejra5Year.ToString(),
                GetDaily = model.GetDaily.ToString(),
                GetMonthly = model.GetMonthly.ToString(),
                GetYear = model.GetYear.ToString(),
                Get5Year = model.Get5Year.ToString(),
                SarfeDaily = model.SarfeDaily.ToString(),
                SarfeMonthly = model.SarfeMonthly.ToString(),
                SarfeYear = model.SarfeYear.ToString(),
                Sarfe5Year = model.Sarfe5Year.ToString(),
                Ch01 = model.Ch01,
                Ch02 = model.Ch02,
                Ch03 = model.Ch03,
                Ch04 = model.Ch04,
                Ch05 = model.Ch05,
                Ch06 = model.Ch06,
                Ch07 = model.Ch07,
                Ch08 = model.Ch08,
                Ch09 = model.Ch09,
                Ch10 = model.Ch10,
                Ch11 = model.Ch11,
                Ch12 = model.Ch12,
                Ch13 = model.Ch13,
                Ch14 = model.Ch14,
                Ch15 = model.Ch15,
                Ch16 = model.Ch16,
                Ch17 = model.Ch17,
                Ch18 = model.Ch18,
                Ch19 = model.Ch19,
                Ch20 = model.Ch20,
                Ch21 = model.Ch21,
                Ch22 = model.Ch22,
                Ch23 = model.Ch23,
                Ch24 = model.Ch24,
                Ch25 = model.Ch25,
                Ch26 = model.Ch26,
                Ch27 = model.Ch27,
                Ch28 = model.Ch28,
                Ch29 = model.Ch29,
                Ch30 = model.Ch30,
                Ch31 = model.Ch31,
                Ch32 = model.Ch32,
                Ch33 = model.Ch33,
                Ch34 = model.Ch34,
                Ch35 = model.Ch35,
                Ch36 = model.Ch36,
                Ch37 = model.Ch37,
                Referrals = new List<Referral>()
                {
                    model.Referral
                },
                HelpersToRegistrar = model.Helpers,
                Registrar = model.Registrar,
                RegistrarParticipatePercent = 100 - model.Helpers.Sum(h => h.Percent)
            };

            await _context.proposals.AddAsync(proposal);
            await _context.SaveChangesAsync();
            return proposal.ID;
        }

        public int CalculateDarsadPishraft(Proposal proposal)
        {
            int impartsCount = 0;
            int darsad = 0;
            foreach (var impart in proposal.Imparts)
            {
                darsad += impart.Reports.Sum(r => r.Percentage);
                impartsCount++;
            }
            return darsad / impartsCount;
        }

        public int CountApprovedProposals(int year)
        {
            int count =_context.proposals.Where(p=>p.StatusID==2|| p.StatusID == 5|| p.StatusID == 9).Count();
            return count;
        }

        public int CountExecutedProposals(int year)
        {
            int count = _context.proposals.Where(p=>p.StatusID==5 && EF.Functions.Like(p.Date,year.ToString()+"/%")).Count();
            return count;
        }

        public int CountGrouhiProposals()
        {
            int count = _context.proposals.Where(p =>p.HelpersToRegistrar.Count!=0).Count();
            return count;
        }

        public int CountGrouhiProposals(int year)
        {
            int count = _context.proposals.Where(p => p.HelpersToRegistrar.Count != 0&&EF.Functions.Like(p.Date, year.ToString() + "/%")).Count();
            return count;
        }

        public int CountProposals()
        {
            int count = _context.proposals.Count();
            return count;
        }

        public int CountProposals(int year)
        {
            int count = _context.proposals.Where(p=>EF.Functions.Like(p.Date,year.ToString()+"/%")).Count();
            return count;
        }

        public int[] CountProposalsInEachMonth(int year)
        {
            int[] months = new int[12];
            for (int i = 1; i <= 12; i++)
            {
                months[i-1] = _context.proposals.Where(p=> EF.Functions.Like(p.Date, year.ToString() + "/"+ i.ToString("0#")+"/%")).Count();
            }
            return months;
        }

        public Task<Proposal> EditProposal(int proposalID, Proposal proposal)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Proposal>> GetAllProposals()
        {
            List<Proposal> proposals = await _context.proposals.ToListAsync();
            return proposals;
        }

        public async Task<List<Proposal>> GetAllProposalsBetWeenTowDateAsync(string startDate, string endDate,int? statusID)
        {
            string query = "select * from dbo.proposals where proposals.[Date]  >= '" + startDate + "' AND proposals.[Date]  <= '" + endDate+"'"+(statusID != -1 ? "AND proposals.[StatusID] = '"+statusID+"'" : "");
            List<Proposal> proposals = await _context.proposals.FromSqlRaw(query).Include(p=>p.Status).Include(p => p.Registrar).ThenInclude(u => u.Office).Include(p => p.HelpersToRegistrar).ThenInclude(p => p.User).ThenInclude(u=>u.Office).ToListAsync();
            return proposals;
        }

        public async Task<string> GetAttachedFileName(int ProposalID)
        {
            string fileName = await _context.proposals.Where(p=>p.ID==ProposalID).Select(p=>p.File).SingleOrDefaultAsync();
            return fileName;
        }


        public async Task<Proposal> GetProposalAsync(ProposalRefrralsViewModel model)
        {
            Proposal proposal = await _context.proposals.Include(p=>p.Referrals).ThenInclude(r=>r.QualityEvaluation)
                                                        .Include(p => p.Referrals).ThenInclude(r => r.QuantitativEvaluation)
                                                        .Include(p => p.Referrals).ThenInclude(r => r.NewQualityEvaluation)
                                                        .Include(p=>p.Referrals).ThenInclude(r=>r.Sender)
                                                        .Include(p=>p.Referrals).ThenInclude(r=>r.Reciver)
                                                        .Include(p=>p.Referrals).ThenInclude(r=>r.Status)
                                                        .Include(p=>p.Referrals).ThenInclude(r=>r.EvaluationType)
                                                        .SingleOrDefaultAsync(p=>p.ID==model.ProposalID);
            return proposal;
        }

        public async Task<Proposal> GetProposalAsync(EditProposalViewModel model)
        {
            Proposal proposal = await _context.proposals.Include(p=>p.Registrar).Include(p => p.HelpersToRegistrar).ThenInclude(h=>h.User).SingleOrDefaultAsync(p=>p.ID==model.ID);
            return proposal;
        }

        public async Task<Proposal> GetProposalAsync(int proposalID)
        {
            Proposal proposal = await _context.proposals.SingleOrDefaultAsync(p=>p.ID==proposalID);
            return proposal;
        }

        public async Task<bool> UpdateProposalAsync(Proposal proposal)
        {
            try
            {
                _context.Entry(proposal).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
