using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class ReferralStatus
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public List<Referral> Referrals { get; set; }
    }
    public class ReferralStatusConfiguration : IEntityTypeConfiguration<ReferralStatus>
    {
        public void Configure(EntityTypeBuilder<ReferralStatus> builder)
        {
            builder.HasMany(e => e.Referrals).WithOne(e => e.Status);
            builder.HasData(new List<ReferralStatus>
            {
                new ReferralStatus
                {
                    ID=1,
                    Title="مشاهده شده"
                },
                new ReferralStatus
                {
                    ID=2,
                    Title="مشاهده نشده"
                },
                new ReferralStatus
                {
                    ID=3,
                    Title="ارزیابی شده"
                },
            });
        }
    }
}
