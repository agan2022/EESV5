using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class CommitteeStatus
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }

        public List<Committee> Committees { get; set; }
    }

    public class CommitteeStatusConfiguration : IEntityTypeConfiguration<CommitteeStatus>
    {
        public void Configure(EntityTypeBuilder<CommitteeStatus> builder)
        {
            builder.HasMany(e => e.Committees).WithOne(e => e.Status);
            builder.HasData(new List<CommitteeStatus>
            {
                new CommitteeStatus
                { 
                    ID=1,
                    Title="فعال",
                },
                new CommitteeStatus
                {
                    ID=2,
                    Title="غیر فعال"
                }
            });
        }
    }
}
