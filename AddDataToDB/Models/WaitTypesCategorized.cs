using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class WaitTypesCategorized
    {
        public string CategoryName { get; set; }
        public string WaitType { get; set; }
        public short CategoryId { get; set; }
        public bool Ignore { get; set; }
    }
}
