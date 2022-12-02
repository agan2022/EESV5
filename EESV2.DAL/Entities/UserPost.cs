using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class UserPost
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public List<User> Users { get; set; }
    }
    public class UserPostConfiguration : IEntityTypeConfiguration<UserPost>
    {
        public void Configure(EntityTypeBuilder<UserPost> builder)
        {
            builder.HasMany(e => e.Users).WithOne(e => e.Post);
            builder.HasData(new UserPost
            {
                ID=1,
                Title="تست"
            });
        }
    }
}
