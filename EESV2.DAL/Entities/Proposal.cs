using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EESV2.DAL.Entities
{
    public class Proposal
    {
        [Key]
        public int ID { get; set; }
        public string SubjectPr { get; set; }
        public string CurrentDescPr { get; set; }
        public string NewDesPr { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string IP { get; set; }
        public string CodeBazr { get; set; }
        public string File { get; set; }
        public string DesDabir { get; set; }
        public bool Ch01 { get; set; }
        public bool Ch02 { get; set; }
        public bool Ch03 { get; set; }
        public bool Ch04 { get; set; }
        public bool Ch05 { get; set; }
        public bool Ch06 { get; set; }
        public bool Ch07 { get; set; }
        public bool Ch08 { get; set; }
        public bool Ch09 { get; set; }
        public bool Ch10 { get; set; }
        public bool Ch11 { get; set; }
        public bool Ch12 { get; set; }
        public bool Ch13 { get; set; }
        public bool Ch14 { get; set; }
        public bool Ch15 { get; set; }
        public bool Ch16 { get; set; }
        public bool Ch17 { get; set; }
        public bool Ch18 { get; set; }
        public bool Ch19 { get; set; }
        public bool Ch20 { get; set; }
        public bool Ch21 { get; set; }
        public bool Ch22 { get; set; }
        public bool Ch23 { get; set; }
        public bool Ch24 { get; set; }
        public bool Ch25 { get; set; }
        public bool Ch26 { get; set; }
        public bool Ch27 { get; set; }
        public bool Ch28 { get; set; }
        public bool Ch29 { get; set; }
        public bool Ch30 { get; set; }
        public bool Ch31 { get; set; }
        public bool Ch32 { get; set; }
        public bool Ch33 { get; set; }
        public bool Ch34 { get; set; }
        public bool Ch35 { get; set; }
        public bool Ch36 { get; set; }
        public bool Ch37 { get; set; }
        public string EjraDaily { get; set; }
        public string EjraMonthly { get; set; }
        public string EjraYear { get; set; }
        public string Ejra5Year { get; set; }
        public string GetDaily { get; set; }
        public string GetMonthly { get; set; }
        public string GetYear { get; set; }
        public string Get5Year { get; set; }
        public string SarfeDaily { get; set; }
        public string SarfeMonthly { get; set; }
        public string SarfeYear { get; set; }
        public string Sarfe5Year { get; set; }


        public int RegistrarID { get; set; }
        public User Registrar { get; set; }//این فیلد ثبت کننده پیشنهاد را مشخص میکند
        public int RegistrarParticipatePercent { get; set; }



        public List<Participant> HelpersToRegistrar { get; set; }//این فیلد لیست کسانی که در ثبت پیشنهاد همکاری کرده اند را نشان میدهد

        public int StatusID { get; set; }
        public ProposalStatus Status { get; set; }


        public List<Impart> Imparts { get; set; }//ابلاغ

        public List<Objection> Objections { get; set; }//هر پیشنهاد یک لیستی از اعتراضات دارد

        public List<Referral> Referrals { get; set; }//ارجاع

        
    }
    public class ProposalConfiguration : IEntityTypeConfiguration<Proposal>
    {
        public void Configure(EntityTypeBuilder<Proposal> builder)
        {
            builder.HasOne(e => e.Status).WithMany(e => e.proposals).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.HelpersToRegistrar).WithOne(e => e.Proposal);
            builder.HasOne(e => e.Registrar).WithMany(e => e.Proposals).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Imparts).WithOne(e => e.Proposal);
            builder.HasMany(e => e.Objections).WithOne(e => e.Proposal);
            builder.HasMany(e => e.Referrals).WithOne(e => e.Proposal);

        }
    }
}
