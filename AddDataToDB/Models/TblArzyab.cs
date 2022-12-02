using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblArzyab
    {
        public int ArzyabId { get; set; }
        public int? Kid { get; set; }
        public int? Agid { get; set; }
        public string EmNo { get; set; }
        public bool? Dabir { get; set; }
    }
}
