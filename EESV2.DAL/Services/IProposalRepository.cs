using EESV2.DAL.Entities;
using EESV2.DAL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EESV2.DAL.Services
{
    public interface IProposalRepository
    {
        public Task<int> AddNewProposal(NewProposalViewModel model);
        public Task<bool> UpdateProposalAsync(Proposal proposal);

        public Task<Proposal> EditProposal(int proposalID,Proposal proposal);

        public Task<List<Proposal>> GetAllProposals();



        public Task<Proposal> GetProposalAsync(int proposalID);
        public Task<Proposal> GetProposalAsync(ProposalRefrralsViewModel model);
        public Task<Proposal> GetProposalAsync(EditProposalViewModel model);

        public Task<List<Proposal>> GetAllProposalsBetWeenTowDateAsync(string startDate,string endDate,int? statusID);

        public Task<string> GetAttachedFileName(int ProposalID);




        public int CountGrouhiProposals();
        public int CountGrouhiProposals(int year);


        public int CountApprovedProposals(int year);

        public int CountExecutedProposals(int year);


        public int CountProposals();
        public int CountProposals(int year);


        public int[] CountProposalsInEachMonth(int year);//تعدد پیشنهادادت در هر ماه در سال ورودی



        public int CalculateDarsadPishraft(Proposal proposal);

    }
}
