using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class DiskUsage
    {
        public long? Dbsize { get; set; }
        public long? Logsize { get; set; }
        public long? Ftsize { get; set; }
        public long? Reservedpages { get; set; }
        public long? Usedpages { get; set; }
        public long? Pages { get; set; }
        public string DatabaseName { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
