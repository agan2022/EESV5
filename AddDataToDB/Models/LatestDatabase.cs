using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class LatestDatabase
    {
        public string Urn { get; set; }
        public string PowershellPath { get; set; }
        public DateTimeOffset ProcessingTime { get; set; }
        public DateTimeOffset? BatchTime { get; set; }
        public string ServerInstanceName { get; set; }
        public string ParentUrn { get; set; }
        public string Collation { get; set; }
        public short? CompatibilityLevel { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? EncryptionEnabled { get; set; }
        public string Name { get; set; }
        public short? RecoveryModel { get; set; }
        public bool? Trustworthy { get; set; }
        public byte? State { get; set; }
    }
}
