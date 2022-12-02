using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class DistinctQueryToHandle
    {
        public long DistinctQueryHash { get; set; }
        public byte[] SqlHandle { get; set; }
        public int SourceId { get; set; }

        public virtual DistinctQuery DistinctQuery { get; set; }
        public virtual NotableQueryText S { get; set; }
        public virtual SourceInfoInternal Source { get; set; }
    }
}
