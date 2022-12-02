using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class DistinctQuery
    {
        public DistinctQuery()
        {
            DistinctQueryToHandles = new HashSet<DistinctQueryToHandle>();
        }

        public long DistinctQueryHash { get; set; }
        public string DistinctSqlText { get; set; }
        public int SourceId { get; set; }

        public virtual SourceInfoInternal Source { get; set; }
        public virtual ICollection<DistinctQueryToHandle> DistinctQueryToHandles { get; set; }
    }
}
