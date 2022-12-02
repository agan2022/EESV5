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
    public class PortalMembershipType
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public List<User> Users { get; set; }
    }
    public class PortalMembershipTypeConfiguration : IEntityTypeConfiguration<PortalMembershipType>
    {
        public void Configure(EntityTypeBuilder<PortalMembershipType> builder)
        {
            builder.HasMany(p => p.Users).WithOne(u => u.PortalMembershipType);
            builder.HasData(new List<PortalMembershipType>
            {
                new PortalMembershipType
                {
                    ID=1,
                    Title="عادی"
                },
                new PortalMembershipType
                {
                    ID=2,
                    Title="رئیس واحد"
                },
                new PortalMembershipType
                {
                    ID=3,
                    Title="عضو شورای مشارکت"
                },
                new PortalMembershipType
                {
                    ID=4,
                    Title="عضو کمیته تخصصی فرعی"
                },
                new PortalMembershipType
                {
                    ID=5,
                    Title="ارزیاب تخصصی"
                }
            });
        }
    }
}
