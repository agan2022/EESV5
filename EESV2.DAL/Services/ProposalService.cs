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
    }
}
