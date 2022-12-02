using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewPost
    {
        public int EduId { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Pic { get; set; }
        public string AddDate { get; set; }
        public string Contents { get; set; }
        public int PartId { get; set; }
        public string PartName { get; set; }
    }
}
