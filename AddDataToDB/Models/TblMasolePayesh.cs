using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblMasolePayesh
    {
        public int Idmasole { get; set; }
        public int? Idpayesh { get; set; }
        public int? ProccessId { get; set; }
        public string Username { get; set; }
        public short? Kpimode { get; set; }
    }
}
