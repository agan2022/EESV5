using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class Committee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int StatusID { get; set; }
        public int SecretaryID { get; set; }



        public CommitteeStatus Status { get; set; }
        public User Secretary { get; set; }
        public List<UserCommittee> Members { get; set; }
    }
    public class CommitteeConfiguration : IEntityTypeConfiguration<Committee>
    {
        public void Configure(EntityTypeBuilder<Committee> builder)
        {
            builder.HasOne(e => e.Status).WithMany(e => e.Committees).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Members).WithOne(e => e.Committee);
            builder.HasOne(e => e.Secretary).WithMany(e => e.CommitteesSecretary).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
