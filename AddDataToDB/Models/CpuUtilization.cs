using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class CpuUtilization
    {
        public byte AggregationType { get; set; }
        public DateTimeOffset ProcessingTime { get; set; }
        public byte ObjectType { get; set; }
        public string PhysicalServerName { get; set; }
        public string ServerInstanceName { get; set; }
        public string DatabaseName { get; set; }
        public float? PercentTotalCpuUtilization { get; set; }
    }
}
