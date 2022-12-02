using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewErjaAryabanLastComplete
    {
        public int? Idpr { get; set; }
        public string SubjectPr { get; set; }
        public int? ArzyabIdDes { get; set; }
        public string Fnamed { get; set; }
        public string Lnamed { get; set; }
        public string Tarikh { get; set; }
        public string SaAt { get; set; }
        public int? StatusId { get; set; }
        public string WorkPhone { get; set; }
    }
}
