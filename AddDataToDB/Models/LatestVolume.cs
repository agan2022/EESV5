using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class LatestVolume
    {
        public int Id { get; set; }
        public string VirtualServerName { get; set; }
        public string PhysicalServerName { get; set; }
        public string VolumeDeviceId { get; set; }
        public string VolumeName { get; set; }
        public string PowershellPath { get; set; }
        public DateTimeOffset ProcessingTime { get; set; }
        public DateTimeOffset? BatchTime { get; set; }
        public float? TotalSpaceAvailable { get; set; }
        public float? TotalSpaceUtilized { get; set; }
        public float? PercentTotalSpaceUtilization { get; set; }
    }
}
