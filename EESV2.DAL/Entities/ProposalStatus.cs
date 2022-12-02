using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class ProposalStatus
    {
        [Key]
        public int ID { get; set; }

        [Display(Name ="عنوان وضعیت")]
        [Required(ErrorMessage ="عنوان وضعیت را وارد کنید.")]
        public string Title { get; set; }

        public List<Proposal> proposals { get; set; }
    }
    public class ProposalStatusConfiguration : IEntityTypeConfiguration<ProposalStatus>
    {
        public void Configure(EntityTypeBuilder<ProposalStatus> builder)
        {
            builder.HasMany(e => e.proposals).WithOne(e => e.Status);
            builder.HasData(new List<PortalMembershipType>
            {
                new PortalMembershipType
                {
                    ID=1,
                    Title="ارجاع به ارزیابی"
                },
                new PortalMembershipType
                {
                    ID=2,
                    Title="تصویب شده"
                },
                new PortalMembershipType
                {
                    ID=3,
                    Title="رد شده"
                },
                new PortalMembershipType
                {
                    ID=4,
                    Title="در دست برسی"
                },
                new PortalMembershipType
                {
                    ID=5,
                    Title="اجرا شده"
                },
                new PortalMembershipType
                {
                    ID=6,
                    Title="عودت از ارزیابی به دبیرخانه"
                },
                new PortalMembershipType
                {
                    ID=7,
                    Title="سایر"
                },
                new PortalMembershipType
                {
                    ID=8,
                    Title="تایید ارزیابی و اماده طرح در شورای مرکزی"
                },
                new PortalMembershipType
                {
                    ID=9,
                    Title="ابلاغ به واحد مجری"
                },
            });
        }
    }
}
