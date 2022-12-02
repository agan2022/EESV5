using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class Impart
    {

        [Key]
        public int ID { get; set; }

        public long? Cost { get; set; }

        public string ExecutorRegistrationDate { get; set; }
        public string ExecutorRegistrationTime { get; set; }
        public string ExecutorIP { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
        public string DescriptionExecute { get; set; }
        public int? TimeToExecute { get; set; }
        public string StartDateExecute { get; set; }
        public string EndDateExecute { get; set; }

        public int ProposalID { get; set; }
        public Proposal Proposal { get; set; }

        public int ExecutorID { get; set; }
        public User Executor { get; set; }

        public List<UserImpart> Hamkaran { get; set; }

        public List<ProgressReport> Reports { get; set; }

        public int ImpartStatusID { get; set; }
        public ImpartStatus ImpartStatus { get; set; }

    }
    public class ImpartConfiguration : IEntityTypeConfiguration<Impart>
    {
        public void Configure(EntityTypeBuilder<Impart> builder)
        {
            builder.HasOne(e => e.Proposal).WithMany(e => e.Imparts).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Executor).WithMany(e => e.Imparts).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Hamkaran).WithOne(e => e.Impart);
            builder.HasMany(e => e.Reports).WithOne(e => e.Impart);
            builder.HasOne(e => e.ImpartStatus).WithMany(e => e.Imparts).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
