using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewLastErjaInbox
    {
        public string Sender { get; set; }
        public int? Idpr { get; set; }
        public string JalaseNo { get; set; }
        public string Tarikh { get; set; }
        public string SubjectPr { get; set; }
        public string Description { get; set; }
    }
}
