using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class PerformanceCounterValue
    {
        public int PerformanceCounterInstanceId { get; set; }
        public int SnapshotId { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public double FormattedValue { get; set; }
        public long RawValueFirst { get; set; }
        public long? RawValueSecond { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
