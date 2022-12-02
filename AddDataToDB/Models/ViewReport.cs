using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewReport
    {
        public int Idpr { get; set; }
        public string Usrid { get; set; }
        public string DateN { get; set; }
        public string TimeN { get; set; }
        public string SubjectPr { get; set; }
        public string Status { get; set; }
        public string Username { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}
