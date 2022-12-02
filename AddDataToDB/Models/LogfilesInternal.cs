using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class LogfilesInternal
    {
        public string Urn { get; set; }
        public string PowershellPath { get; set; }
        public DateTimeOffset ProcessingTime { get; set; }
        public DateTimeOffset? BatchTime { get; set; }
        public string ServerInstanceName { get; set; }
        public string DatabaseName { get; set; }
        public string ParentUrn { get; set; }
        public string PhysicalServerName { get; set; }
        public string VolumeName { get; set; }
        public string VolumeDeviceId { get; set; }
        public float? Growth { get; set; }
        public short? GrowthType { get; set; }
        public float? MaxSize { get; set; }
        public string Name { get; set; }
        public float? Size { get; set; }
        public float? UsedSpace { get; set; }
        public string FileName { get; set; }
        public long? VolumeFreeSpace { get; set; }
    }
}
