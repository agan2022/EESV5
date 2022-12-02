using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EESV2.DAL.Entities
{
    public class EmploymentType
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public List<User> Users { get; set; }
    }
    public class EmploymentTypeConfiguration : IEntityTypeConfiguration<EmploymentType>
    {
        public void Configure(EntityTypeBuilder<EmploymentType> builder)
        {
            builder.HasMany(e => e.Users).WithOne(u=>u.EmploymentType);
            builder.HasData(new List<EmploymentType>
            {
                new EmploymentType
                {
                    ID=1,
                    Title="رسمی"
                },
                new EmploymentType
                {
                    ID=2,
                    Title="قرار دادی"
                },
                new EmploymentType
                {
                    ID=3,
                    Title="پیمانکاری"
                }
            });
        }
    }
}
