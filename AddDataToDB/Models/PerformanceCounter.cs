using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class PerformanceCounter
    {
        public int PerformanceCounterId { get; set; }
        public int SnapshotId { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public string Path { get; set; }
        public string PerformanceObjectName { get; set; }
        public string PerformanceCounterName { get; set; }
        public string PerformanceInstanceName { get; set; }
        public double FormattedValue { get; set; }
        public long RawValueFirst { get; set; }
        public long? RawValueSecond { get; set; }
    }
}
