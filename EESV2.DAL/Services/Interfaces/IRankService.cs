using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EESV2.DAL.Entities;
using EESV2.DAL.ViewModels;
using EESV2.DAL.ViewModels.TopMemberReport;

namespace EESV2.DAL.Services.Interfaces
{
    public interface IRankService
    {
        #region Rank Calculator

        public List<UserRankViewModel> RankCalculation();

        public List<UserRankViewModel> RankCalculation(List<int> officeIDs, int year, int month);

        public List<UserRankViewModel> TopMembersRankCalculation(TopMemberViewModel model);

        public List<UserRankViewModel> CalculatedScoreOfProposal(List<User> users);

        public List<UserRankViewModel> CalculatedScoreOfParticipantProposal(List<User> users2, List<UserRankViewModel> userRank);

        #endregion

        #region Progress Calculation

        public double ProgressCalculation(int proposalId);

        #endregion
    }
}
