using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblProbLog
    {
        public int Id { get; set; }
        public int? Idpr { get; set; }
        public string Tarikh { get; set; }
        public string SaAt { get; set; }
        public string Ip { get; set; }
        public string UserName { get; set; }
        public int? NewStatusId { get; set; }
    }
}
