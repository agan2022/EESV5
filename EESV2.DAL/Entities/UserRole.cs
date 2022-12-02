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
    public class UserRole
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasOne(u => u.Role).WithMany(r => r.UserRoles).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(u => u.User).WithMany(r => r.UserRoles).OnDelete(DeleteBehavior.Restrict);
            /*builder.HasData(new UserRole
            {
                ID = 1,
                RoleID =1,
                UserID=1
            });*/
        }
    }
}
