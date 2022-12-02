using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class OsLatchStat
    {
        public string LatchClass { get; set; }
        public long WaitingRequestsCount { get; set; }
        public long WaitTimeMs { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
