using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EESContext _context;
        public UnitOfWork(EESContext context)
        {
            _context=context;
        }



        private GenericCRUD<Impart> _impartRepository { get; set; }
        private GenericCRUD<ProgressReport> _progressReportRepository { get; set; }
        private GenericCRUD<Proposal> _proposalRepository { get; set; }
        private GenericCRUD<Objection> _objectionRepository { get; set; }
        private GenericCRUD<User> _userRepository { get; set; }
        private GenericCRUD<VisitorStatistic> _visitorStatisticRepository { get; set; }
        private GenericCRUD<Notification> _notificationRepository { get; set; }
        private GenericCRUD<UserPost> _userPostRepository { get; set; }
        private GenericCRUD<Office> _officeRepository { get; set; }
        private GenericCRUD<PortalMembershipType> _portalMembershipTypeRepository { get; set; }
        private GenericCRUD<EmploymentType> _employmentTypeRepository { get; set; }
        private GenericCRUD<UserStatus> _userStatusRepository { get; set; }
        private GenericCRUD<Referral> _referralRepository { get; set; }
        private GenericCRUD<NewQualityEvaluation> _newQualityEvaluationRepository { get; set; }
        private GenericCRUD<Role> _roleRepository { get; set; }
        private GenericCRUD<Survey> _surveyRepository { get; set; }
        private GenericCRUD<Committee> _committeeRepository { get; set; }
        private GenericCRUD<Form> _formRepository { get; set; }
        private GenericCRUD<EvaluationType> _evaluationTypeRepository { get; set; }
        private GenericCRUD<UserImpart> _userImpartRepository { get; set; }
        private GenericCRUD<UserCommittee> _userCommitteeRepository { get; set; }
        private GenericCRUD<UserRole> _userRoleRepository { get; set; }
        private GenericCRUD<ImpartStatus> _impartStatusRepository { get; set; }
        private GenericCRUD<CommitteeStatus> _committeeStatusRepository { get; set; }
        private GenericCRUD<QuantitativEvaluation> _quantitativEvaluationRepository { get; set; }
        private GenericCRUD<Participant> _participantRepository { get; set; }
        private GenericCRUD<ProposalStatus> _proposalStatusRepository { get; set; }
        public GenericCRUD<Impart> ImpartRepository
        {
            get
            {
                if (_impartRepository==null)
                {
                    _impartRepository = new GenericCRUD<Impart>(_context);
                }
                return _impartRepository;
            }
        }
        public GenericCRUD<ProgressReport> ProgressReportRepository
        {
            get
            {
                if (_progressReportRepository == null)
                {
                    _progressReportRepository = new GenericCRUD<ProgressReport>(_context);
                }
                return _progressReportRepository;
            }
        }

        public GenericCRUD<Proposal> ProposalRepository
        {
            get
            {
                if (_proposalRepository == null)
                {
                    _proposalRepository = new GenericCRUD<Proposal>(_context);
                }
                return _proposalRepository;
            }
        }
        public GenericCRUD<Objection> ObjectionRepository
        {
            get
            {
                if (_objectionRepository == null)
                {
                    _objectionRepository = new GenericCRUD<Objection>(_context);
                }
                return _objectionRepository;
            }
        }

        public GenericCRUD<User> UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new GenericCRUD<User>(_context);
                }
                return _userRepository;
            }
        }
        public GenericCRUD<VisitorStatistic> VisitorStatisticRepository
        {
            get
            {
                if (_visitorStatisticRepository == null)
                {
                    _visitorStatisticRepository = new GenericCRUD<VisitorStatistic>(_context);
                }
                return _visitorStatisticRepository;
            }
        }
        public GenericCRUD<Notification> NotificationRepository
        {
            get
            {
                if (_notificationRepository == null)
                {
                    _notificationRepository = new GenericCRUD<Notification>(_context);
                }
                return _notificationRepository;
            }
        }
        public GenericCRUD<UserPost> UserPostRepository
        {
            get
            {
                if (_userPostRepository == null)
                {
                    _userPostRepository = new GenericCRUD<UserPost>(_context);
                }
                return _userPostRepository;
            }
        }
        public GenericCRUD<Office> OfficeRepository
        {
            get
            {
                if (_officeRepository == null)
                {
                    _officeRepository = new GenericCRUD<Office>(_context);
                }
                return _officeRepository;
            }
        }
        public GenericCRUD<PortalMembershipType> PortalMembershipTypeRepository
        {
            get
            {
                if (_portalMembershipTypeRepository == null)
                {
                    _portalMembershipTypeRepository = new GenericCRUD<PortalMembershipType>(_context);
                }
                return _portalMembershipTypeRepository;
            }
        }
        public GenericCRUD<EmploymentType> EmploymentTypeRepository
        {
            get
            {
                if (_employmentTypeRepository == null)
                {
                    _employmentTypeRepository = new GenericCRUD<EmploymentType>(_context);
                }
                return _employmentTypeRepository;
            }
        }
        public GenericCRUD<UserStatus> UserStatusRepository
        {
            get
            {
                if (_userStatusRepository == null)
                {
                    _userStatusRepository = new GenericCRUD<UserStatus>(_context);
                }
                return _userStatusRepository;
            }
        }
        public GenericCRUD<Referral> ReferralRepository
        {
            get
            {
                if (_referralRepository == null)
                {
                    _referralRepository = new GenericCRUD<Referral>(_context);
                }
                return _referralRepository;
            }
        }
        public GenericCRUD<NewQualityEvaluation> NewQualityEvaluationRepository
        {
            get
            {
                if (_newQualityEvaluationRepository == null)
                {
                    _newQualityEvaluationRepository = new GenericCRUD<NewQualityEvaluation>(_context);
                }
                return _newQualityEvaluationRepository;
            }
        }
        public GenericCRUD<Role> RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = new GenericCRUD<Role>(_context);
                }
                return _roleRepository;
            }
        }
        public GenericCRUD<Survey> SurveyRepository
        {
            get
            {
                if (_surveyRepository == null)
                {
                    _surveyRepository = new GenericCRUD<Survey>(_context);
                }
                return _surveyRepository;
            }
        }
        public GenericCRUD<Committee> CommitteeRepository
        {
            get
            {
                if (_committeeRepository == null)
                {
                    _committeeRepository = new GenericCRUD<Committee>(_context);
                }
                return _committeeRepository;
            }
        }
        public GenericCRUD<Form> FormRepository
        {
            get
            {
                if (_formRepository == null)
                {
                    _formRepository = new GenericCRUD<Form>(_context);
                }
                return _formRepository;
            }
        }
        public GenericCRUD<EvaluationType> EvaluationTypeRepository
        {
            get
            {
                if (_evaluationTypeRepository == null)
                {
                    _evaluationTypeRepository = new GenericCRUD<EvaluationType>(_context);
                }
                return _evaluationTypeRepository;
            }
        }
        public GenericCRUD<UserImpart> UserImpartRepository
        {
            get
            {
                if (_userImpartRepository == null)
                {
                    _userImpartRepository = new GenericCRUD<UserImpart>(_context);
                }
                return _userImpartRepository;
            }
        }
        public GenericCRUD<UserCommittee> UserCommitteeRepository
        {
            get
            {
                if (_userImpartRepository == null)
                {
                    _userCommitteeRepository = new GenericCRUD<UserCommittee>(_context);
                }
                return _userCommitteeRepository;
            }
        }
        public GenericCRUD<UserRole> UserRoleRepository
        {
            get
            {
                if (_userRoleRepository == null)
                {
                    _userRoleRepository = new GenericCRUD<UserRole>(_context);
                }
                return _userRoleRepository;
            }
        }
        public GenericCRUD<ImpartStatus> ImpartStatusRepository
        {
            get
            {
                if (_impartStatusRepository == null)
                {
                    _impartStatusRepository = new GenericCRUD<ImpartStatus>(_context);
                }
                return _impartStatusRepository;
            }
        }
        public GenericCRUD<CommitteeStatus> CommitteeStatusRepository
        {
            get
            {
                if (_committeeStatusRepository == null)
                {
                    _committeeStatusRepository = new GenericCRUD<CommitteeStatus>(_context);
                }
                return _committeeStatusRepository;
            }
        }
        public GenericCRUD<QuantitativEvaluation> QuantitativEvaluationRepository
        {
            get
            {
                if (_quantitativEvaluationRepository == null)
                {
                    _quantitativEvaluationRepository = new GenericCRUD<QuantitativEvaluation>(_context);
                }
                return _quantitativEvaluationRepository;
            }
        }
        public GenericCRUD<Participant> ParticipantRepository
        {
            get
            {
                if (_participantRepository == null)
                {
                    _participantRepository = new GenericCRUD<Participant>(_context);
                }
                return _participantRepository;
            }
        }
        public GenericCRUD<ProposalStatus> ProposalStatusRepository
        {
            get
            {
                if (_proposalStatusRepository == null)
                {
                    _proposalStatusRepository = new GenericCRUD<ProposalStatus>(_context);
                }
                return _proposalStatusRepository;
            }
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
