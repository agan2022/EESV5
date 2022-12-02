using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class Form
    {
        [Key]
        public int ID { get; set; }

        public string DocumentName { get; set; }
        public string DocumentCode { get; set; }
        public string DocumentType { get; set; }
        public string OfficeName { get; set; }
        public string FormName { get; set; }
        public string FormCode { get; set; }

        public string File { get; set; }

        public string Level3ProcessName { get; set; }
        public string Level3ProcessCode { get; set; }
        public string Level4ProcessName { get; set; }
        public string Level4ProcessCode { get; set; }
    }
}
