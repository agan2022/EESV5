using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class WaitCategory
    {
        public WaitCategory()
        {
            WaitTypes = new HashSet<WaitType>();
        }

        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Ignore { get; set; }

        public virtual ICollection<WaitType> WaitTypes { get; set; }
    }
}
