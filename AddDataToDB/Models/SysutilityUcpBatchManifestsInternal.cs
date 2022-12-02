using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class SysutilityUcpBatchManifestsInternal
    {
        public string ServerInstanceName { get; set; }
        public DateTimeOffset BatchTime { get; set; }
        public string ParameterName { get; set; }
        public object ParameterValue { get; set; }
        public DateTimeOffset? CollectionTime { get; set; }
        public int? SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
