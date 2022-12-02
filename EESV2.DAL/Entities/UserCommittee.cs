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
    public class UserCommittee
    {
        [Key]
        public int ID { get; set; }
        public int UserId { get; set; }
        public int CommitteeID { get; set; }
        public User User { get; set; }
        public Committee Committee { get; set; }
    }
    public class UserCommitteeConfiguration : IEntityTypeConfiguration<UserCommittee>
    {
        public void Configure(EntityTypeBuilder<UserCommittee> builder)
        {
            builder.HasOne(u => u.User).WithMany(r => r.UserCommittees).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(u => u.Committee).WithMany(r => r.Members).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
