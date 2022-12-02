using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class LatestInstanceCpuUtilization
    {
        public string ServerInstanceName { get; set; }
        public float? InstanceProcessorUsage { get; set; }
        public DateTimeOffset BatchTime { get; set; }
    }
}
