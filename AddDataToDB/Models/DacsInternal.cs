using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class DacsInternal
    {
        public int DacId { get; set; }
        public string ServerInstanceName { get; set; }
        public string DacName { get; set; }
        public string Urn { get; set; }
        public string PowershellPath { get; set; }
        public string PhysicalServerName { get; set; }
        public DateTime? DacDeployDate { get; set; }
        public string DacDescription { get; set; }
        public float? DacPercentTotalCpuUtilization { get; set; }
        public DateTimeOffset ProcessingTime { get; set; }
        public DateTimeOffset? BatchTime { get; set; }
    }
}
