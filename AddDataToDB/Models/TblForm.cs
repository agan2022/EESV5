using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblForm
    {
        public string FormId { get; set; }
        public string FormName { get; set; }
        public string DopId { get; set; }
        public string ZipAddress { get; set; }
    }
}
