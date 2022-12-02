using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewArzyaban
    {
        public int ArzyabId { get; set; }
        public int? WgId { get; set; }
        public string WgName { get; set; }
        public int? ArgId { get; set; }
        public string ArgName { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string EmP { get; set; }
        public bool? Dabir { get; set; }
        public int ManId { get; set; }
        public string ManName { get; set; }
        public string WorkPhone { get; set; }
    }
}
