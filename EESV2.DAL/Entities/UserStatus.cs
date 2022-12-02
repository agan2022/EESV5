using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class UserStatus
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public List<User> Users { get; set; }
    }
    public class UserStatusConfiguration : IEntityTypeConfiguration<UserStatus>
    {
        public void Configure(EntityTypeBuilder<UserStatus> builder)
        {
            builder.HasMany(e => e.Users).WithOne(e => e.Status);
            builder.HasData(new List<UserStatus>
            {
                new UserStatus
                {
                    ID=1,
                    Title="فعال"
                },
                new UserStatus
                {
                    ID=2,
                    Title="غیر فعال"
                },
                new UserStatus
                {
                    ID=3,
                    Title="بازنشسته"
                },
            });
        }
    }
}
