using EESV2.DAL.Entities;
using EESV2.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Services
{
    public interface IUnitOfWork
    {
        public GenericCRUD<Impart> ImpartRepository { get; }
        public GenericCRUD<ProgressReport> ProgressReportRepository { get; }
        public GenericCRUD<Proposal> ProposalRepository { get; }
        public GenericCRUD<Objection> ObjectionRepository { get; }
        public GenericCRUD<User> UserRepository { get; }

        public GenericCRUD<UserPost> UserPostRepository { get; }
        public GenericCRUD<Office> OfficeRepository { get; }
        public GenericCRUD<VisitorStatistic> VisitorStatisticRepository { get; }
        public GenericCRUD<PortalMembershipType> PortalMembershipTypeRepository { get; }
        public GenericCRUD<EmploymentType> EmploymentTypeRepository { get; }
        public GenericCRUD<Notification> NotificationRepository { get; }
        public GenericCRUD<UserStatus> UserStatusRepository { get; }
        public GenericCRUD<Referral> ReferralRepository { get; }
        public GenericCRUD<NewQualityEvaluation> NewQualityEvaluationRepository { get; }
        public GenericCRUD<Role> RoleRepository { get; }
        public GenericCRUD<Survey> SurveyRepository { get; }
        public GenericCRUD<Committee> CommitteeRepository { get; }
        public GenericCRUD<Form> FormRepository { get; }
        public GenericCRUD<EvaluationType> EvaluationTypeRepository { get; }
        public GenericCRUD<UserImpart> UserImpartRepository { get; }
        public GenericCRUD<UserCommittee> UserCommitteeRepository { get; }
        public GenericCRUD<UserRole> UserRoleRepository { get; }
        public GenericCRUD<ImpartStatus> ImpartStatusRepository { get; }
        public GenericCRUD<CommitteeStatus> CommitteeStatusRepository { get; }
        public GenericCRUD<QuantitativEvaluation> QuantitativEvaluationRepository { get; }
        public GenericCRUD<Participant> ParticipantRepository { get; }
        public GenericCRUD<ProposalStatus> ProposalStatusRepository { get; }
        public Task SaveChangesAsync();
    }
}
