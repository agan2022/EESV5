using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.ViewModels
{
    public class UserRankViewModel
    {
        public int ID { get; set; }
        public int Rank { get; set; }
        public string PersonnelCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Office { get; set; }
        public int ProposalCount { get; set; }
        public int Score { get; set; }
    }
}
