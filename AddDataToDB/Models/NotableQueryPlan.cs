using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class NotableQueryPlan
    {
        public byte[] SqlHandle { get; set; }
        public byte[] PlanHandle { get; set; }
        public int StatementStartOffset { get; set; }
        public int StatementEndOffset { get; set; }
        public long PlanGenerationNum { get; set; }
        public DateTimeOffset CreationTime { get; set; }
        public short? DatabaseId { get; set; }
        public int? ObjectId { get; set; }
        public string ObjectName { get; set; }
        public string QueryPlan { get; set; }
        public int SourceId { get; set; }

        public virtual SourceInfoInternal Source { get; set; }
    }
}
