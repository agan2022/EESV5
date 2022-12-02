using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewRepEjra
    {
        public int? Idpr { get; set; }
        public int? Darsad { get; set; }
        public int? EblaghId { get; set; }
        public string Username { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Tarikh { get; set; }
    }
}
