using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class Role
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasMany(e => e.UserRoles).WithOne(e => e.Role);
            builder.HasData(new List<Role>()
            {
                new Role
                {
                    ID=1,
                    Title="Secretary"
                }
            });
        }
    }
}
