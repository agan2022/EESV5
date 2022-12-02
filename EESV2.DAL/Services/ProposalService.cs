using EESV2.DAL.Services.Interfaces;
using EESV2.DAL.ViewModels.Prroposal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Services
{
    public class ProposalService: IProposalService
    {
        private IUnitOfWork _uw;

        public ProposalService(IUnitOfWork uw)
        {
            _uw = uw;
        }



        #region Proposal

        #region Participant Proposal

        public List<ParticipantProposalViewModel> GetParticipantProposal(string userName)
        {
            return _uw.ParticipantRepository.Get(p => p.User.Username == userName)
                .Select(p => p.Proposal)
                .Select(p => new ParticipantProposalViewModel()
                {
                    ID = p.ID,
                    Date = p.Date,
                    SubjectPr = p.SubjectPr,
                    Status = p.Status.Title,
                    StatusID = p.StatusID
                }).ToList();
        }

        #endregion

        #endregion
    }
}
