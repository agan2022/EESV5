using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class Snapshot
    {
        public int SourceId { get; set; }
        public int SnapshotId { get; set; }
        public int SnapshotTimeId { get; set; }
        public DateTimeOffset SnapshotTime { get; set; }
        public DateTimeOffset? ValidThrough { get; set; }
        public string InstanceName { get; set; }
        public Guid CollectionSetUid { get; set; }
        public string Operator { get; set; }
        public long LogId { get; set; }
    }
}
