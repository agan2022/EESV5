using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class SpaceUtilization
    {
        public byte AggregationType { get; set; }
        public DateTimeOffset ProcessingTime { get; set; }
        public byte ObjectType { get; set; }
        public string VirtualServerName { get; set; }
        public string VolumeDeviceId { get; set; }
        public string ServerInstanceName { get; set; }
        public string DatabaseName { get; set; }
        public string FilegroupName { get; set; }
        public string DbfileName { get; set; }
        public float? TotalSpaceBytes { get; set; }
        public float? AllocatedSpaceBytes { get; set; }
        public float? UsedSpaceBytes { get; set; }
        public float? AvailableSpaceBytes { get; set; }
    }
}
