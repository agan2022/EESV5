using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class PerformanceCounterInstance
    {
        public int PerformanceCounterId { get; set; }
        public string Path { get; set; }
        public string ObjectName { get; set; }
        public string CounterName { get; set; }
        public string InstanceName { get; set; }
        public int CounterType { get; set; }
    }
}
