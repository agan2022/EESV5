using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class OsMemoryNode
    {
        public short MemoryNodeId { get; set; }
        public long VirtualAddressSpaceReservedKb { get; set; }
        public long VirtualAddressSpaceCommittedKb { get; set; }
        public long LockedPageAllocationsKb { get; set; }
        public long SinglePagesKb { get; set; }
        public long MultiPagesKb { get; set; }
        public long SharedMemoryReservedKb { get; set; }
        public long SharedMemoryCommittedKb { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
