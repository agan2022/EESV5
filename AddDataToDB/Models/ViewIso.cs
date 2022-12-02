using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewIso
    {
        public string FormId { get; set; }
        public string FormName { get; set; }
        public string Pdfaddress { get; set; }
        public string WordAddress { get; set; }
        public int ManId { get; set; }
        public string ManName { get; set; }
    }
}
