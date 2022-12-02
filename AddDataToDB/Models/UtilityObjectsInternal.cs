using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class UtilityObjectsInternal
    {
        public string ObjectSchema { get; set; }
        public string ObjectName { get; set; }
        public string SqlObjectType { get; set; }
        public string UtilityObjectType { get; set; }
    }
}
