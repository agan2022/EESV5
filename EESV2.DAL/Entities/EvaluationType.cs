using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class EvaluationType
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }

        public List<Referral> Referrals { get; set; }

    }
    public class EvaluationTypeConfiguration : IEntityTypeConfiguration<EvaluationType>
    {
        public void Configure(EntityTypeBuilder<EvaluationType> builder)
        {
            builder.HasMany(e => e.Referrals).WithOne(e => e.EvaluationType);
            builder.HasData(new List<EvaluationType>
            {
                new EvaluationType
                {
                    ID=1,
                    Title="فرم کمی"
                },
                new EvaluationType
                {
                    ID=2,
                    Title="فرم کیفی"
                },
                new EvaluationType
                {
                    ID=3,
                    Title="نامشخص"
                }
            });
        }
    }
}
