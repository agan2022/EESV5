using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class LatestDacCpuUtilization
    {
        public string PhysicalServerName { get; set; }
        public string ServerInstanceName { get; set; }
        public string DacDb { get; set; }
        public DateTime? DacDeployDate { get; set; }
        public string DacDescription { get; set; }
        public string DacName { get; set; }
        public long? LifetimeCpuTimeMs { get; set; }
        public float? LatestCpuPct { get; set; }
        public long? LatestIntervalCpuTimeMs { get; set; }
        public DateTimeOffset? LatestIntervalStartTime { get; set; }
        public DateTimeOffset? LatestIntervalEndTime { get; set; }
        public DateTimeOffset BatchTime { get; set; }
        public string Urn { get; set; }
        public string PowershellPath { get; set; }
    }
}
