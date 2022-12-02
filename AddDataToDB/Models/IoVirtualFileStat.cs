using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class IoVirtualFileStat
    {
        public string DatabaseName { get; set; }
        public int DatabaseId { get; set; }
        public string LogicalFileName { get; set; }
        public int FileId { get; set; }
        public string TypeDesc { get; set; }
        public string LogicalDisk { get; set; }
        public long? NumOfReads { get; set; }
        public long? NumOfBytesRead { get; set; }
        public long? IoStallReadMs { get; set; }
        public long? NumOfWrites { get; set; }
        public long? NumOfBytesWritten { get; set; }
        public long? IoStallWriteMs { get; set; }
        public long? SizeOnDiskBytes { get; set; }
        public DateTimeOffset CollectionTime { get; set; }
        public int SnapshotId { get; set; }

        public virtual SnapshotsInternal Snapshot { get; set; }
    }
}
