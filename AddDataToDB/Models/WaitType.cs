using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class WaitType
    {
        public short CategoryId { get; set; }
        public string WaitType1 { get; set; }

        public virtual WaitCategory Category { get; set; }
    }
}
