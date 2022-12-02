using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblWorkGroupPerson
    {
        public int WgpId { get; set; }
        public string EmP { get; set; }
        public int? WgId { get; set; }
        public bool? Dabir { get; set; }
    }
}
