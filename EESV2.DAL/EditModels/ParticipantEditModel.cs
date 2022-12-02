using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class ParticipantEditModel
    {
        public int Percent { get; set; }
        public int UserID { get; set; }
        public int ProposalID { get; set; }
    }
}
