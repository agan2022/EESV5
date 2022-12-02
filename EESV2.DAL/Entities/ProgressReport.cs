using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class ProgressReport
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public string File { get; set; }
        public int Percentage { get; set; }
        public string Defects { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string IP { get; set; }

        public int ImpartID { get; set; }
        public Impart Impart { get; set; }
    }

    public class DetailsReportsImpartConfiguration : IEntityTypeConfiguration<ProgressReport>
    {
        public void Configure(EntityTypeBuilder<ProgressReport> builder)
        {
            builder.HasOne(e => e.Impart).WithMany(e => e.Reports).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
