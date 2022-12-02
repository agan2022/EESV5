using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class Referral
    {
        [Key]
        public int ID { get; set; }
        public string MeetingNo { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string IP { get; set; }
        public string Result { get; set; }

        public int SenderID { get; set; }
        public User Sender { get; set; }

        public int ReciverID { get; set; }
        public User Reciver { get; set; }

        public int ProposalID { get; set; }
        public Proposal Proposal { get; set; }

        public int? EvaluationTypeID { get; set; }
        public EvaluationType EvaluationType { get; set; }//دو نوع ارزیابی وجود دارد کمی و کیفی

        public QualityEvaluation QualityEvaluation { get; set; }

        public QuantitativEvaluation QuantitativEvaluation { get; set; }

        public NewQualityEvaluation NewQualityEvaluation { get; set; }

        public int StatusID { get; set; }
        public ReferralStatus Status { get; set; }
    }
    public class ReferralConfiguration : IEntityTypeConfiguration<Referral>
    {
        public void Configure(EntityTypeBuilder<Referral> builder)
        {
            builder.HasOne(e => e.Sender).WithMany(e => e.SentReferrals).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Reciver).WithMany(e => e.RecivedReferrals).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Proposal).WithMany(e => e.Referrals).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.EvaluationType).WithMany(e => e.Referrals).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.QualityEvaluation).WithOne(e => e.Referral).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.QuantitativEvaluation).WithOne(e => e.Referral).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.NewQualityEvaluation).WithOne(e => e.Referral).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Status).WithMany(e => e.Referrals).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
