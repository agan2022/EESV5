using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class VisitorStatistic
    {
        [Key]
        public int ID { get; set; }

        public string Date { get; set; }

        public int VisitCount { get; set; }
    }
}
