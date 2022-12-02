using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class LatestComputerCpuMemoryConfiguration
    {
        public long? Rank { get; set; }
        public string VirtualServerName { get; set; }
        public short? IsClusteredServer { get; set; }
        public string PhysicalServerName { get; set; }
        public int? NumProcessors { get; set; }
        public string CpuName { get; set; }
        public string CpuCaption { get; set; }
        public string CpuFamily { get; set; }
        public string CpuArchitecture { get; set; }
        public decimal? CpuMaxClockSpeed { get; set; }
        public decimal? CpuClockSpeed { get; set; }
        public decimal? L2CacheSize { get; set; }
        public decimal? L3CacheSize { get; set; }
        public float? ServerProcessorUsage { get; set; }
        public DateTimeOffset BatchTime { get; set; }
        public string Urn { get; set; }
        public string PowershellPath { get; set; }
    }
}
