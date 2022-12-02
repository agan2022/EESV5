using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblUsrMsg
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Msg { get; set; }
        public bool? OnceVisible { get; set; }
        public bool? Remove { get; set; }
    }
}
