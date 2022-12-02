using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class OsWaitStat
    {
        public string WaitType { get; set; }
        public long WaitingTasksCount { get; set; }
        public long WaitTimeMs { get; set; }
        public long SignalWaitTimeMs { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
