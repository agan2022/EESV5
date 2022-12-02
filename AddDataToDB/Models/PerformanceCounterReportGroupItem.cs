using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class PerformanceCounterReportGroupItem
    {
        public int CounterGroupItemId { get; set; }
        public string CounterGroupId { get; set; }
        public string CounterSubgroupId { get; set; }
        public string SeriesName { get; set; }
        public string ObjectName { get; set; }
        public bool ObjectNameWildcards { get; set; }
        public string CounterName { get; set; }
        public string InstanceName { get; set; }
        public string NotInstanceName { get; set; }
        public decimal MultiplyBy { get; set; }
        public bool DivideByCpuCount { get; set; }
    }
}
