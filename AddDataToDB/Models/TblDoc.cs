using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblDoc
    {
        public string DocId { get; set; }
        public string DocName { get; set; }
        public string FourLevelNo { get; set; }
        public int? DocTypeId { get; set; }
        public int? ManId { get; set; }
        public string ZipAddress { get; set; }
    }
}
