using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewLogDl
    {
        public int ManId { get; set; }
        public string ManName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? ActiveFlag { get; set; }
        public string Semat { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string AddressHome { get; set; }
        public string WorkPhone { get; set; }
        public string EmP { get; set; }
        public int Id { get; set; }
        public string FileId { get; set; }
        public string FileTypeId { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
