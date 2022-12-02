using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblBazr
    {
        public int BId { get; set; }
        public string BSubject { get; set; }
        public string Source { get; set; }
        public string ExpireDt { get; set; }
    }
}
