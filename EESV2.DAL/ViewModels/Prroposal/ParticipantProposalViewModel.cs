using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels.Prroposal
{
    public class ParticipantProposalViewModel
    {
        public int ID { get; set; }

        public int StatusID { get; set; }

        public string Date { get; set; }

        public string SubjectPr { get; set; }

        public string Status { get; set; }
    }
}
