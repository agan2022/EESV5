using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class SysutilityUcpVolumesInternal
    {
        public string ServerInstanceName { get; set; }
        public string VirtualServerName { get; set; }
        public string PhysicalServerName { get; set; }
        public string VolumeDeviceId { get; set; }
        public string VolumeName { get; set; }
        public float? TotalSpaceAvailable { get; set; }
        public float? FreeSpace { get; set; }
        public DateTimeOffset BatchTime { get; set; }
        public DateTimeOffset? CollectionTime { get; set; }
        public int? SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
