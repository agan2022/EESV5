using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class FilegroupsInternal
    {
        public string Urn { get; set; }
        public string PowershellPath { get; set; }
        public DateTimeOffset ProcessingTime { get; set; }
        public DateTimeOffset? BatchTime { get; set; }
        public string ServerInstanceName { get; set; }
        public string DatabaseName { get; set; }
        public string ParentUrn { get; set; }
        public string Name { get; set; }
    }
}
