using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewArzyab
    {
        public int ArgId { get; set; }
        public string ArgName { get; set; }
        public int ArgpId { get; set; }
        public string EmP { get; set; }
        public string Username { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string ManName { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? ActiveFlag { get; set; }
        public string Semat { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string AddressHome { get; set; }
        public string WorkPhone { get; set; }
    }
}
