using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class LatestSmoServer
    {
        public string Urn { get; set; }
        public string PowershellPath { get; set; }
        public DateTimeOffset ProcessingTime { get; set; }
        public DateTimeOffset? BatchTime { get; set; }
        public short? AuditLevel { get; set; }
        public string BackupDirectory { get; set; }
        public string BrowserServiceAccount { get; set; }
        public short? BrowserStartMode { get; set; }
        public string BuildClrVersionString { get; set; }
        public int? BuildNumber { get; set; }
        public string Collation { get; set; }
        public int? CollationId { get; set; }
        public int? ComparisonStyle { get; set; }
        public string ComputerNamePhysicalNetBios { get; set; }
        public string DefaultFile { get; set; }
        public string DefaultLog { get; set; }
        public string Edition { get; set; }
        public short? EngineEdition { get; set; }
        public string ErrorLogPath { get; set; }
        public string FilestreamShareName { get; set; }
        public string InstallDataDirectory { get; set; }
        public string InstallSharedDirectory { get; set; }
        public string InstanceName { get; set; }
        public bool? IsCaseSensitive { get; set; }
        public bool? IsClustered { get; set; }
        public bool? IsFullTextInstalled { get; set; }
        public bool? IsSingleUser { get; set; }
        public string Language { get; set; }
        public string MailProfile { get; set; }
        public string MasterDblogPath { get; set; }
        public string MasterDbpath { get; set; }
        public byte? MaxPrecision { get; set; }
        public string Name { get; set; }
        public bool? NamedPipesEnabled { get; set; }
        public string NetName { get; set; }
        public int? NumberOfLogFiles { get; set; }
        public string Osversion { get; set; }
        public short? PerfMonMode { get; set; }
        public int? PhysicalMemory { get; set; }
        public string Platform { get; set; }
        public short? Processors { get; set; }
        public int? ProcessorUsage { get; set; }
        public string Product { get; set; }
        public string ProductLevel { get; set; }
        public string ResourceVersionString { get; set; }
        public string RootDirectory { get; set; }
        public short? ServerType { get; set; }
        public string ServiceAccount { get; set; }
        public string ServiceInstanceId { get; set; }
        public string ServiceName { get; set; }
        public short? ServiceStartMode { get; set; }
        public short? SqlCharSet { get; set; }
        public string SqlCharSetName { get; set; }
        public string SqlDomainGroup { get; set; }
        public short? SqlSortOrder { get; set; }
        public string SqlSortOrderName { get; set; }
        public short? Status { get; set; }
        public int? TapeLoadWaitTime { get; set; }
        public bool? TcpEnabled { get; set; }
        public int? VersionMajor { get; set; }
        public int? VersionMinor { get; set; }
        public string VersionString { get; set; }
    }
}
