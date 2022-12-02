using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.DAL.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? CreateDate { get; set; }
        public int StatusID { get; set; }
        public UserStatus Status { get; set; }
        public int PostID { get; set; }
        public UserPost  Post { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string AddressHome { get; set; }
        public string WorkPhone { get; set; }
        public string Pic { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<Proposal> Proposals { get; set; }//لیست پیشنهاداتی که این کاربر ثبت کننده ان بوده است
        public List<Participant> ProposalsThatHelped { get; set; }//لیست پیشنهاداتی که این کاربر در ثبت انها هماری کرده و کس دیگر آنرا ثبت کرده است
        public int OfficeID { get; set; }
        public Office Office { get; set; }

        public int EmploymentTypeID { get; set; }
        public EmploymentType EmploymentType { get; set; }

        public int PortalMembershipTypeID { get; set; }
        public PortalMembershipType PortalMembershipType { get; set; }

        public List<Referral> SentReferrals { get; set; }
        public List<Referral> RecivedReferrals { get; set; }

        public List<UserCommittee> UserCommittees { get; set; }
        public List<Committee> CommitteesSecretary { get; set; }

        public List<Impart> Imparts { get; set; }//این لیست لیست ابلاغ هایی است که کاربر مجری آنهاست

        public List<UserImpart> HamkarImparts { get; set; }//این لیست لیست ابلاغ هایی است که کاربر همکار مجری آنهاست


        public List<Objection> Objections { get; set; }//هر یوزر میتواند یک لیستی از اعتراض ها به نتیجه پیشنهاد داشته باشد
        public List<Survey> Surveys { get; set; }
    }
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(e => e.Status).WithMany(e => e.Users).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Post).WithMany(e => e.Users).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(u => u.EmploymentType).WithMany(e => e.Users).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(u => u.PortalMembershipType).WithMany(e => e.Users).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.UserRoles).WithOne(e => e.User);
            builder.HasMany(e => e.ProposalsThatHelped).WithOne(e => e.User);
            builder.HasMany(e => e.Proposals).WithOne(e => e.Registrar);
            builder.HasOne(e => e.Office).WithMany(e => e.Users).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.SentReferrals).WithOne(e => e.Sender);
            builder.HasMany(e => e.RecivedReferrals).WithOne(e => e.Reciver);
            builder.HasMany(e => e.UserCommittees).WithOne(e => e.User);
            builder.HasMany(e => e.CommitteesSecretary).WithOne(e => e.Secretary);
            builder.HasMany(e => e.Imparts).WithOne(e => e.Executor);
            builder.HasMany(e => e.HamkarImparts).WithOne(e => e.User);
            builder.HasMany(e => e.Objections).WithOne(e => e.User);
            builder.HasMany(u => u.Surveys).WithOne(u=>u.User);

            /*builder.HasData(new User 
            {
                ID = 1,
                Username = "111111",
                Password = "1f40fc92da241694750979ee6cf582f2d5d7d28e18335de05abc54d0560e0f5302860c652bf08d560252aa5e74210546f369fbbbce8c12cfc7957b2652fe9a75",
                FirstName="Admin",
                LastName="Admin",
                AddressHome="",
                HomePhone="",
                Mobile="",
                Pic="",
                OfficeID=1,
                PortalMembershipTypeID=1,
                EmploymentTypeID = 1,
                StatusID = 1,
                PostID=1
            });*/
        }
    }
}
