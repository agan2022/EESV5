using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class DistinctQueryStat
    {
        public long DistinctQueryHash { get; set; }
        public long? ExecutionCount { get; set; }
        public long? TotalWorkerTime { get; set; }
        public long? TotalPhysicalReads { get; set; }
        public long? TotalLogicalReads { get; set; }
        public long? TotalLogicalWrites { get; set; }
        public long? TotalClrTime { get; set; }
        public long? TotalElapsedTime { get; set; }
    }
}
