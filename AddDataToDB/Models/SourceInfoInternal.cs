using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class SourceInfoInternal
    {
        public SourceInfoInternal()
        {
            DistinctQueries = new HashSet<DistinctQuery>();
            DistinctQueryToHandles = new HashSet<DistinctQueryToHandle>();
            NotableQueryPlans = new HashSet<NotableQueryPlan>();
            NotableQueryTexts = new HashSet<NotableQueryText>();
            SnapshotsInternals = new HashSet<SnapshotsInternal>();
            TraceInfos = new HashSet<TraceInfo>();
        }

        public int SourceId { get; set; }
        public Guid CollectionSetUid { get; set; }
        public string InstanceName { get; set; }
        public short DaysUntilExpiration { get; set; }
        public string Operator { get; set; }

        public virtual ICollection<DistinctQuery> DistinctQueries { get; set; }
        public virtual ICollection<DistinctQueryToHandle> DistinctQueryToHandles { get; set; }
        public virtual ICollection<NotableQueryPlan> NotableQueryPlans { get; set; }
        public virtual ICollection<NotableQueryText> NotableQueryTexts { get; set; }
        public virtual ICollection<SnapshotsInternal> SnapshotsInternals { get; set; }
        public virtual ICollection<TraceInfo> TraceInfos { get; set; }
    }
}
