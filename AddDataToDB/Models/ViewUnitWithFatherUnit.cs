using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewUnitWithFatherUnit
    {
        public int Ids { get; set; }
        public string Unit { get; set; }
        public string FatherUnit { get; set; }
    }
}
