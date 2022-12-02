using EESV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using static EESV2.DAL.Entities.Committee;

namespace EESV2.DAL
{
    public class EESContext:DbContext
    {
        public EESContext()
        {

        }
        public EESContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EESV3;Data Source=.");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommitteeConfiguration());
            modelBuilder.ApplyConfiguration(new CommitteeStatusConfiguration());
            modelBuilder.ApplyConfiguration(new DetailsReportsImpartConfiguration());
            modelBuilder.ApplyConfiguration(new EvaluationTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ImpartConfiguration());
            modelBuilder.ApplyConfiguration(new ImpartStatusConfiguration());
            modelBuilder.ApplyConfiguration(new ObjectionConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new ProposalConfiguration());
            modelBuilder.ApplyConfiguration(new ProposalStatusConfiguration());
            modelBuilder.ApplyConfiguration(new ReferralConfiguration());
            modelBuilder.ApplyConfiguration(new ReferralStatusConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserPostConfiguration());
            modelBuilder.ApplyConfiguration(new UserStatusConfiguration());
            modelBuilder.ApplyConfiguration(new PortalMembershipTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EmploymentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new NewQualityEvaluationConfiguration());
            modelBuilder.ApplyConfiguration(new SurveyConfiguration());
            modelBuilder.ApplyConfiguration(new UserImpartConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserCommitteeConfiguration());
        }
        public DbSet<Committee> Committees { get; set; }
        public DbSet<CommitteeStatus> CommitteeStatuses { get; set; }
        public DbSet<ProgressReport> ProgressReports { get; set; }
        public DbSet<EvaluationType> EvaluationTypes { get; set; }
        public DbSet<Impart> Imparts { get; set; }
        public DbSet<ImpartStatus> ImpartStatuses { get; set; }
        public DbSet<Objection> Objections { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Proposal> proposals { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<ProposalStatus> ProposalStatuses { get; set; }
        public DbSet<QualityEvaluation> QualityEvaluations { get; set; }
        public DbSet<QuantitativEvaluation> QuantitativEvaluations { get; set; }
        public DbSet<NewQualityEvaluation> NewQualityEvaluations { get; set; }
        public DbSet<Referral> Referrals { get; set; }
        public DbSet<ReferralStatus> ReferralStatuses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<PortalMembershipType> PortalMembershipTypes { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<UserCommittee> UserCommittees { get; set; }
        public DbSet<UserImpart> UserImparts { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

    }
}
