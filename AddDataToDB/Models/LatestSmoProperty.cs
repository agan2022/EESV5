using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class LatestSmoProperty
    {
        public string PhysicalServerName { get; set; }
        public string ServerInstanceName { get; set; }
        public string Urn { get; set; }
        public int? ObjectType { get; set; }
        public string PropertyName { get; set; }
        public object PropertyValue { get; set; }
        public int? SnapshotId { get; set; }
        public DateTimeOffset? BatchTime { get; set; }
    }
}
