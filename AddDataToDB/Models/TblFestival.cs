using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblFestival
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Descr { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string Pict { get; set; }
    }
}
