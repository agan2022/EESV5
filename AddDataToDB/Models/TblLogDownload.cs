using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblLogDownload
    {
        public int Id { get; set; }
        public string FileId { get; set; }
        public string FileTypeId { get; set; }
        public DateTime? DateTime { get; set; }
        public string UserName { get; set; }
    }
}
