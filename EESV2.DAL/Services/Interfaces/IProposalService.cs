using EESV2.DAL.ViewModels.Prroposal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Services.Interfaces
{
    public interface IProposalService
    {
        #region Proposal

        #region Participant Proposal

        List<ParticipantProposalViewModel> GetParticipantProposal(string userName);

        #endregion

        #endregion
    }
}
