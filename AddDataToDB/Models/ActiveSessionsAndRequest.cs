using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ActiveSessionsAndRequest
    {
        public int RowId { get; set; }
        public short SessionId { get; set; }
        public int RequestId { get; set; }
        public int ExecContextId { get; set; }
        public short? BlockingSessionId { get; set; }
        public int? BlockingExecContextId { get; set; }
        public int? SchedulerId { get; set; }
        public string DatabaseName { get; set; }
        public int? UserId { get; set; }
        public string TaskState { get; set; }
        public string RequestStatus { get; set; }
        public string SessionStatus { get; set; }
        public bool? ExecutingManagedCode { get; set; }
        public DateTimeOffset LoginTime { get; set; }
        public bool IsUserProcess { get; set; }
        public string HostName { get; set; }
        public string ProgramName { get; set; }
        public string LoginName { get; set; }
        public string WaitType { get; set; }
        public string LastWaitType { get; set; }
        public long WaitDurationMs { get; set; }
        public string WaitResource { get; set; }
        public string ResourceDescription { get; set; }
        public long? TransactionId { get; set; }
        public int OpenTransactionCount { get; set; }
        public short? TransactionIsolationLevel { get; set; }
        public int? RequestCpuTime { get; set; }
        public long? RequestLogicalReads { get; set; }
        public long? RequestReads { get; set; }
        public long? RequestWrites { get; set; }
        public int? RequestTotalElapsedTime { get; set; }
        public DateTimeOffset? RequestStartTime { get; set; }
        public int MemoryUsage { get; set; }
        public int SessionCpuTime { get; set; }
        public long SessionReads { get; set; }
        public long SessionWrites { get; set; }
        public long SessionLogicalReads { get; set; }
        public int SessionTotalScheduledTime { get; set; }
        public int SessionTotalElapsedTime { get; set; }
        public DateTimeOffset SessionLastRequestStartTime { get; set; }
        public DateTimeOffset? SessionLastRequestEndTime { get; set; }
        public int? OpenResultsets { get; set; }
        public long SessionRowCount { get; set; }
        public int PrevError { get; set; }
        public int? PendingIoCount { get; set; }
        public string Command { get; set; }
        public byte[] PlanHandle { get; set; }
        public byte[] SqlHandle { get; set; }
        public int? StatementStartOffset { get; set; }
        public int? StatementEndOffset { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }
        public bool IsBlocking { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
