using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewForm
    {
        public string ThreeLevelId { get; set; }
        public string ThreeLevelName { get; set; }
        public string FourLevelNo { get; set; }
        public string FourLevelName { get; set; }
        public int DocTypeInt { get; set; }
        public string DocTypeName { get; set; }
        public string DocId { get; set; }
        public string DocName { get; set; }
        public string FormName { get; set; }
        public string FormId { get; set; }
        public string ZipAddress { get; set; }
        public int ManId { get; set; }
        public string ManName { get; set; }
    }
}
