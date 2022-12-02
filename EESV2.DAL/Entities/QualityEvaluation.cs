using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace EESV2.DAL.Entities
{
    public class QualityEvaluation
    {
        [Key]
        public int ID { get; set; }
        public bool? PishOk { get; set; }
        public byte? Quality { get; set; }
        public double? HrWork { get; set; }
        public int? K1 { get; set; }
        public int? K2 { get; set; }
        public int? K3 { get; set; }
        public int? K4 { get; set; }
        public int? K5 { get; set; }
        public int? K6 { get; set; }
        public int? K7 { get; set; }
        public int? K8 { get; set; }
        public string RejectReason { get; set; }

        public int ReferralID { get; set; }
        public Referral Referral { get; set; }
    }
    public class QualityEvaluationConfiguration : IEntityTypeConfiguration<QualityEvaluation>
    {
        public void Configure(EntityTypeBuilder<QualityEvaluation> builder)
        {
            builder.HasOne(e => e.Referral).WithOne(e => e.QualityEvaluation).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
