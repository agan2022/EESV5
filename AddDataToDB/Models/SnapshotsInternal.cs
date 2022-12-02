using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class SnapshotsInternal
    {
        public SnapshotsInternal()
        {
            ActiveSessionsAndRequests = new HashSet<ActiveSessionsAndRequest>();
            DiskUsages = new HashSet<DiskUsage>();
            IoVirtualFileStats = new HashSet<IoVirtualFileStat>();
            LogUsages = new HashSet<LogUsage>();
            OsLatchStats = new HashSet<OsLatchStat>();
            OsMemoryNodes = new HashSet<OsMemoryNode>();
            OsProcessMemories = new HashSet<OsProcessMemory>();
            OsSchedulers = new HashSet<OsScheduler>();
            OsWaitStats = new HashSet<OsWaitStat>();
            PerformanceCounterValues = new HashSet<PerformanceCounterValue>();
            SqlProcessAndSystemMemories = new HashSet<SqlProcessAndSystemMemory>();
            SysutilityUcpCpuMemoryConfigurationsInternals = new HashSet<SysutilityUcpCpuMemoryConfigurationsInternal>();
            SysutilityUcpDacCollectedExecutionStatisticsInternals = new HashSet<SysutilityUcpDacCollectedExecutionStatisticsInternal>();
            SysutilityUcpVolumesInternals = new HashSet<SysutilityUcpVolumesInternal>();
            TraceInfos = new HashSet<TraceInfo>();
        }

        public int SnapshotId { get; set; }
        public int SnapshotTimeId { get; set; }
        public int SourceId { get; set; }
        public long LogId { get; set; }

        public virtual SnapshotTimetableInternal SnapshotTime { get; set; }
        public virtual SourceInfoInternal Source { get; set; }
        public virtual ICollection<ActiveSessionsAndRequest> ActiveSessionsAndRequests { get; set; }
        public virtual ICollection<DiskUsage> DiskUsages { get; set; }
        public virtual ICollection<IoVirtualFileStat> IoVirtualFileStats { get; set; }
        public virtual ICollection<LogUsage> LogUsages { get; set; }
        public virtual ICollection<OsLatchStat> OsLatchStats { get; set; }
        public virtual ICollection<OsMemoryNode> OsMemoryNodes { get; set; }
        public virtual ICollection<OsProcessMemory> OsProcessMemories { get; set; }
        public virtual ICollection<OsScheduler> OsSchedulers { get; set; }
        public virtual ICollection<OsWaitStat> OsWaitStats { get; set; }
        public virtual ICollection<PerformanceCounterValue> PerformanceCounterValues { get; set; }
        public virtual ICollection<SqlProcessAndSystemMemory> SqlProcessAndSystemMemories { get; set; }
        public virtual ICollection<SysutilityUcpCpuMemoryConfigurationsInternal> SysutilityUcpCpuMemoryConfigurationsInternals { get; set; }
        public virtual ICollection<SysutilityUcpDacCollectedExecutionStatisticsInternal> SysutilityUcpDacCollectedExecutionStatisticsInternals { get; set; }
        public virtual ICollection<SysutilityUcpVolumesInternal> SysutilityUcpVolumesInternals { get; set; }
        public virtual ICollection<TraceInfo> TraceInfos { get; set; }
    }
}
