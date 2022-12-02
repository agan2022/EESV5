using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class SysutilityUcpDacCollectedExecutionStatisticsInternal
    {
        public string PhysicalServerName { get; set; }
        public string ServerInstanceName { get; set; }
        public string DacDb { get; set; }
        public DateTime? DacDeployDate { get; set; }
        public string DacDescription { get; set; }
        public string DacName { get; set; }
        public DateTimeOffset? IntervalStartTime { get; set; }
        public DateTimeOffset? IntervalEndTime { get; set; }
        public long? IntervalCpuTimeMs { get; set; }
        public float? IntervalCpuPct { get; set; }
        public long? LifetimeCpuTimeMs { get; set; }
        public DateTimeOffset BatchTime { get; set; }
        public DateTimeOffset? CollectionTime { get; set; }
        public int? SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
