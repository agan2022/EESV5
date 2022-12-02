using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class EstimationCostFormEditModel
    {
        public int? ProposalID { get; set; }
        public int? ID { get; set; }
        public string SubjectPr { get; set; }
        public string OfficeName { get; set; }
        public string Date { get; set; }
        public long? Cost { get; set; }
        public int? TimeToExecute { get; set; }

        public string ExecutorUserName { get; set; }
        public int[] HamkaranIDs { get; set; }


        public string DescriptionExecute { get; set; }

        public string StartDateExecute { get; set; }
        public string EndDateExecute { get; set; }
    }
}
