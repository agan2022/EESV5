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
    public class NewQualityEvaluation
    {
        [Key]
        public int ID { get; set; }
        public bool? PishOk { get; set; }
        public byte? Quality { get; set; }
        public double? HrWork { get; set; }


        /*هر کدام از فیلد های زیر پاسخ یک سوال کیفی را به صورت خوب یا خیلی خوب یا ... نگه میدارد متن سوالات در صورتجلسه و همچنین در صفحه فرم پیشنهاد کیفی وجود دارد*/
        public int Q1 { get; set; }
        public int Q2 { get; set; }
        public int Q3 { get; set; }
        public int Q4 { get; set; }
        public int Q5 { get; set; }
        public int Q6 { get; set; }
        public int Q7 { get; set; }
        public int Q8 { get; set; }
        public int Q9 { get; set; }
        public int Q10 { get; set; }
        public int Q11 { get; set; }
        public int Q12 { get; set; }
        public int Q13 { get; set; }
        public int Q14 { get; set; }
        public int Q15 { get; set; }
        public int Q16 { get; set; }
        public int Q17 { get; set; }
        public int Q18 { get; set; }
        public string RejectReason { get; set; }

        public int ReferralID { get; set; }
        public Referral Referral { get; set; }
    }
    public class NewQualityEvaluationConfiguration : IEntityTypeConfiguration<NewQualityEvaluation>
    {
        public void Configure(EntityTypeBuilder<NewQualityEvaluation> builder)
        {
            builder.HasOne(n => n.Referral).WithOne(r => r.NewQualityEvaluation).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
