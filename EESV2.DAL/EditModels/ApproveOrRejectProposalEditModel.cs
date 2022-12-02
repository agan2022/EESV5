using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class ApproveOrRejectProposalEditModel
    {
        public int ID { get; set; }
        public string DesDabir { get; set; }
        public int StatusID { get; set; }
    }
}
