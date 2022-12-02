using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.EditModels
{
    public class AddMembersToCommitteeEditModel
    {
        public int ID { get; set; }
        public int[] MembersIDs { get; set; }
    }
}
