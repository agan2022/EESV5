using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class OsScheduler
    {
        public int ParentNodeId { get; set; }
        public int SchedulerId { get; set; }
        public int CpuId { get; set; }
        public string Status { get; set; }
        public bool IsIdle { get; set; }
        public int PreemptiveSwitchesCount { get; set; }
        public int ContextSwitchesCount { get; set; }
        public int YieldCount { get; set; }
        public int CurrentTasksCount { get; set; }
        public int RunnableTasksCount { get; set; }
        public long WorkQueueCount { get; set; }
        public int PendingDiskIoCount { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
