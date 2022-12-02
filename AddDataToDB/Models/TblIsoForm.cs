using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblIsoForm
    {
        public string FormId { get; set; }
        public string FormName { get; set; }
        public int? DepId { get; set; }
        public string Pdfaddress { get; set; }
        public string WordAddress { get; set; }
    }
}
