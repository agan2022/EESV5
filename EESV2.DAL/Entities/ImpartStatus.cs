using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class ImpartStatus
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }

        public List<Impart> Imparts { get; set; }

    }
    public class ImpartStatusConfiguration : IEntityTypeConfiguration<ImpartStatus>
    {
        public void Configure(EntityTypeBuilder<ImpartStatus> builder)
        {
            builder.HasMany(e => e.Imparts).WithOne(e => e.ImpartStatus);
            builder.HasData(new List<ImpartStatus>
            {
                new ImpartStatus
                {
                    ID=1,
                    Title="نامشخص"
                },
                new ImpartStatus
                {
                    ID=2,
                    Title="تایید و ابلاغ اجرایه توسط دبیرخانه نظام مشارکت و اقدام جهت اجرا"
                },
                new ImpartStatus
                {
                    ID=3,
                    Title="انجام برآورد مجری - منتظر تایید دبیرخانه نظام مشارکت"
                },
                new ImpartStatus
                {
                    ID=4,
                    Title="لطفا برآورد هزینه، برنامه، همکاران اجرایی پیشنهاد بررسی مجدد گردد"
                },
                new ImpartStatus
                {
                    ID=5,
                    Title="ارسال به ستاد انتقال"
                },
                new ImpartStatus
                {
                    ID=6,
                    Title="ارسال به ستاد ملی گاز"
                }

            });
        }
    }
}
