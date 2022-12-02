using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class NotableQueryText
    {
        public NotableQueryText()
        {
            DistinctQueryToHandles = new HashSet<DistinctQueryToHandle>();
        }

        public byte[] SqlHandle { get; set; }
        public short? DatabaseId { get; set; }
        public int? ObjectId { get; set; }
        public string ObjectName { get; set; }
        public string SqlText { get; set; }
        public int SourceId { get; set; }

        public virtual SourceInfoInternal Source { get; set; }
        public virtual ICollection<DistinctQueryToHandle> DistinctQueryToHandles { get; set; }
    }
}
