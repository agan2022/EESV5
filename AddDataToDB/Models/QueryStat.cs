using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class QueryStat
    {
        public byte[] SqlHandle { get; set; }
        public int StatementStartOffset { get; set; }
        public int StatementEndOffset { get; set; }
        public long PlanGenerationNum { get; set; }
        public byte[] PlanHandle { get; set; }
        public DateTimeOffset CreationTime { get; set; }
        public DateTimeOffset LastExecutionTime { get; set; }
        public long ExecutionCount { get; set; }
        public long? SnapshotExecutionCount { get; set; }
        public long TotalWorkerTime { get; set; }
        public long SnapshotWorkerTime { get; set; }
        public long? MinWorkerTime { get; set; }
        public long MaxWorkerTime { get; set; }
        public long TotalPhysicalReads { get; set; }
        public long SnapshotPhysicalReads { get; set; }
        public long? MinPhysicalReads { get; set; }
        public long MaxPhysicalReads { get; set; }
        public long TotalLogicalWrites { get; set; }
        public long SnapshotLogicalWrites { get; set; }
        public long? MinLogicalWrites { get; set; }
        public long MaxLogicalWrites { get; set; }
        public long TotalLogicalReads { get; set; }
        public long SnapshotLogicalReads { get; set; }
        public long? MinLogicalReads { get; set; }
        public long MaxLogicalReads { get; set; }
        public long? TotalClrTime { get; set; }
        public long? SnapshotClrTime { get; set; }
        public long? MinClrTime { get; set; }
        public long? MaxClrTime { get; set; }
        public long TotalElapsedTime { get; set; }
        public long SnapshotElapsedTime { get; set; }
        public long? MinElapsedTime { get; set; }
        public long MaxElapsedTime { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
