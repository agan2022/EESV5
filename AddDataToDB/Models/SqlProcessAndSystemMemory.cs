using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class SqlProcessAndSystemMemory
    {
        public long SqlPhysicalMemoryInUseKb { get; set; }
        public long SqlLargePageAllocationsKb { get; set; }
        public long SqlLockedPageAllocationsKb { get; set; }
        public long SqlTotalVirtualAddressSpaceKb { get; set; }
        public long SqlVirtualAddressSpaceReservedKb { get; set; }
        public long SqlVirtualAddressSpaceCommittedKb { get; set; }
        public long SqlVirtualAddressSpaceAvailableKb { get; set; }
        public long SqlPageFaultCount { get; set; }
        public int SqlMemoryUtilizationPercentage { get; set; }
        public long SqlAvailableCommitLimitKb { get; set; }
        public bool SqlProcessPhysicalMemoryLow { get; set; }
        public bool SqlProcessVirtualMemoryLow { get; set; }
        public long SystemTotalPhysicalMemoryKb { get; set; }
        public long SystemAvailablePhysicalMemoryKb { get; set; }
        public long SystemTotalPageFileKb { get; set; }
        public long SystemAvailablePageFileKb { get; set; }
        public long SystemCacheKb { get; set; }
        public long SystemKernelPagedPoolKb { get; set; }
        public long SystemKernelNonpagedPoolKb { get; set; }
        public bool SystemHighMemorySignalState { get; set; }
        public bool SystemLowMemorySignalState { get; set; }
        public long BpoolCommitTarget { get; set; }
        public long BpoolCommitted { get; set; }
        public long BpoolVisible { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
