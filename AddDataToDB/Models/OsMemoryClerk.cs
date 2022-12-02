using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class OsMemoryClerk
    {
        public string Type { get; set; }
        public short? MemoryNodeId { get; set; }
        public long? SinglePagesKb { get; set; }
        public long? MultiPagesKb { get; set; }
        public long? VirtualMemoryReservedKb { get; set; }
        public long? VirtualMemoryCommittedKb { get; set; }
        public long? AweAllocatedKb { get; set; }
        public long? SharedMemoryReservedKb { get; set; }
        public long? SharedMemoryCommittedKb { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
