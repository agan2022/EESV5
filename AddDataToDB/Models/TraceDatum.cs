using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TraceDatum
    {
        public int TraceInfoId { get; set; }
        public int SnapshotId { get; set; }
        public string TextData { get; set; }
        public byte[] BinaryData { get; set; }
        public int? DatabaseId { get; set; }
        public long? TransactionId { get; set; }
        public int? LineNumber { get; set; }
        public string NtuserName { get; set; }
        public string NtdomainName { get; set; }
        public string HostName { get; set; }
        public int? ClientProcessId { get; set; }
        public string ApplicationName { get; set; }
        public string LoginName { get; set; }
        public int? Spid { get; set; }
        public long? Duration { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }
        public long? Reads { get; set; }
        public long? Writes { get; set; }
        public int? Cpu { get; set; }
        public long? Permissions { get; set; }
        public int? Severity { get; set; }
        public int? EventSubClass { get; set; }
        public int? ObjectId { get; set; }
        public int? Success { get; set; }
        public int? IndexId { get; set; }
        public int? IntegerData { get; set; }
        public string ServerName { get; set; }
        public int? EventClass { get; set; }
        public int? ObjectType { get; set; }
        public int? NestLevel { get; set; }
        public int? State { get; set; }
        public int? Error { get; set; }
        public int? Mode { get; set; }
        public int? Handle { get; set; }
        public string ObjectName { get; set; }
        public string DatabaseName { get; set; }
        public string FileName { get; set; }
        public string OwnerName { get; set; }
        public string RoleName { get; set; }
        public string TargetUserName { get; set; }
        public string DbuserName { get; set; }
        public byte[] LoginSid { get; set; }
        public string TargetLoginName { get; set; }
        public byte[] TargetLoginSid { get; set; }
        public int? ColumnPermissions { get; set; }
        public string LinkedServerName { get; set; }
        public string ProviderName { get; set; }
        public string MethodName { get; set; }
        public long? RowCounts { get; set; }
        public int? RequestId { get; set; }
        public long? XactSequence { get; set; }
        public long EventSequence { get; set; }
        public long? BigintData1 { get; set; }
        public long? BigintData2 { get; set; }
        public Guid? Guid { get; set; }
        public int? IntegerData2 { get; set; }
        public long? ObjectId2 { get; set; }
        public int? Type { get; set; }
        public int? OwnerId { get; set; }
        public string ParentName { get; set; }
        public int? IsSystem { get; set; }
        public int? Offset { get; set; }
        public int? SourceDatabaseId { get; set; }
        public byte[] SqlHandle { get; set; }
        public string SessionLoginName { get; set; }
        public byte[] PlanHandle { get; set; }
        public int? GroupId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
        public virtual TraceInfo TraceInfo { get; set; }
    }
}
