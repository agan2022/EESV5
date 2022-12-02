using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class Objection
    {
        [Key]
        public int ID { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
        public string IP { get; set; }

        public string Result { get; set; }
        public string Reasons { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }//هر اعتراض را یک کاربر ثبت  میکند

        public int ProposalID { get; set; }
        public Proposal Proposal { get; set; }//هر اعتراض مربوط به یک پیشنهاد است

    }
    public class ObjectionConfiguration : IEntityTypeConfiguration<Objection>
    {
        public void Configure(EntityTypeBuilder<Objection> builder)
        {
            builder.HasOne(e => e.User).WithMany(e => e.Objections).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Proposal).WithMany(e => e.Objections).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
