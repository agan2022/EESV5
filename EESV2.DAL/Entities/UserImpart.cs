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
    public class UserImpart
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ImpartID { get; set; }
        public User User { get; set; }
        public Impart Impart { get; set; }
    }
    public class UserImpartConfiguration : IEntityTypeConfiguration<UserImpart>
    {
        public void Configure(EntityTypeBuilder<UserImpart> builder)
        {
            builder.HasOne(u => u.User).WithMany(u => u.HamkarImparts).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(u => u.Impart).WithMany(u => u.Hamkaran).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
