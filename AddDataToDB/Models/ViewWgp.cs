using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewWgp
    {
        public int WgId { get; set; }
        public string WgName { get; set; }
        public bool? WgStatus { get; set; }
        public int WgpId { get; set; }
        public string EmP { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int ManId { get; set; }
        public string ManName { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? ActiveFlag { get; set; }
        public string Semat { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string AddressHome { get; set; }
        public string WorkPhone { get; set; }
        public bool? Dabir { get; set; }
    }
}
