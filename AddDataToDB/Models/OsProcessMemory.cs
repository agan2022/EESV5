using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class OsProcessMemory
    {
        public long PhysicalMemoryInUseKb { get; set; }
        public long LargePageAllocationsKb { get; set; }
        public long LockedPageAllocationsKb { get; set; }
        public long TotalVirtualAddressSpaceKb { get; set; }
        public long VirtualAddressSpaceReservedKb { get; set; }
        public long VirtualAddressSpaceCommittedKb { get; set; }
        public long VirtualAddressSpaceAvailableKb { get; set; }
        public long PageFaultCount { get; set; }
        public int MemoryUtilizationPercentage { get; set; }
        public long AvailableCommitLimitKb { get; set; }
        public bool ProcessPhysicalMemoryLow { get; set; }
        public bool ProcessVirtualMemoryLow { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
