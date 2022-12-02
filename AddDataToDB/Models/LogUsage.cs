using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class LogUsage
    {
        public string DatabaseName { get; set; }
        public double? LogSizeMb { get; set; }
        public double? LogSpaceUsed { get; set; }
        public int? Status { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
