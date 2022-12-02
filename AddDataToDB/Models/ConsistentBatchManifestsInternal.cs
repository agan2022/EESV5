using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ConsistentBatchManifestsInternal
    {
        public string ServerInstanceName { get; set; }
        public DateTimeOffset BatchTime { get; set; }
    }
}
