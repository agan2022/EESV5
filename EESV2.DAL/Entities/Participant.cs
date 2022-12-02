using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace EESV2.DAL.Entities
{
    public class Participant
    {
        public int ID { get; set; }
        public int Percent { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int ProposalID { get; set; }
        public Proposal Proposal { get; set; }
    }
    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.HasOne(p=>p.User).WithMany(p=>p.ProposalsThatHelped).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Proposal).WithMany(p => p.HelpersToRegistrar).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
