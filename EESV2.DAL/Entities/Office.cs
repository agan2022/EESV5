using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class Office
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int? ParrentOfficeID { get; set; }
        public Office ParrentOffice { get; set; }

        public List<Office> ChildOffices { get; set; }

        public List<User> Users { get; set; }
    }
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasOne(e => e.ParrentOffice).WithMany(e => e.ChildOffices).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.ChildOffices).WithOne(e => e.ParrentOffice);
            builder.HasMany(e => e.Users).WithOne(e => e.Office);
            /*builder.HasData(new Office
            {
                ID = 1,
                Name = "اداره پیشفرض"
            });*/
        }
    }
}
