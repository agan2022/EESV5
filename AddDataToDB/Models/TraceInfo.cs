using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TraceInfo
    {
        public int TraceInfoId { get; set; }
        public int SourceId { get; set; }
        public int CollectionItemId { get; set; }
        public int? LastSnapshotId { get; set; }
        public DateTime? StartTime { get; set; }
        public long? LastEventSequence { get; set; }
        public bool? IsRunning { get; set; }
        public long? EventCount { get; set; }
        public int? DroppedEventCount { get; set; }

        public virtual SnapshotsInternal LastSnapshot { get; set; }
        public virtual SourceInfoInternal Source { get; set; }
    }
}
