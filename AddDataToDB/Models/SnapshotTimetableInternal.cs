using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class SnapshotTimetableInternal
    {
        public SnapshotTimetableInternal()
        {
            SnapshotsInternals = new HashSet<SnapshotsInternal>();
        }

        public int SnapshotTimeId { get; set; }
        public DateTimeOffset SnapshotTime { get; set; }

        public virtual ICollection<SnapshotsInternal> SnapshotsInternals { get; set; }
    }
}
