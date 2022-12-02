using AutoMapper;
using EESV2.DAL.EditModels;
using EESV2.DAL.Entities;
using EESV2.DAL.ViewModels;
namespace EESV2.AutoMapping
{
    public class AutoMap:Profile
    {
        public AutoMap()
        {
            CreateMap<User, CreateUserEditModel>().ReverseMap();
            CreateMap<User, EditUserEditModel>().ReverseMap();
            CreateMap<User, EditUserByUserEditModel>().ReverseMap();

            CreateMap<Proposal, CreateProposalEditModel>().ReverseMap();
            CreateMap<Proposal, ApproveOrRejectProposalEditModel>().ReverseMap();


            CreateMap<CreateReferralEditModel, Referral>().ReverseMap();
            CreateMap<Proposal, EditProposalEditModel>().ReverseMap();
            CreateMap<NewQualityEvaluation,CreateNewQualitativeEvaluationViewModel>().ReverseMap();
            CreateMap<Survey, CreateSurveyViewModel>().ReverseMap();
            CreateMap<Survey, DetailsSurveyViewModel>().ReverseMap();
            CreateMap<Office, CreateOfficeEditModel>().ReverseMap();
            CreateMap<Office, EditOfficeViewModel>().ReverseMap();
            CreateMap<Form, DetailsFormViewModel>().ReverseMap();

            CreateMap<Notification, CreateNotificationEditModel>().ReverseMap();
            CreateMap<Notification, EditNotificationEditModel>().ReverseMap();

            CreateMap<Committee, CreateCommitteeEditModel>().ReverseMap();
            CreateMap<Committee, EditCommitteeEditModel>().ReverseMap();

            CreateMap<Impart, EstimationCostFormEditModel>().ReverseMap();
            CreateMap<Impart, SecretaryEstimationCostFormEditModel>().ReverseMap();

            CreateMap<UserPost, CreateUserPostEditModel>().ReverseMap();
            CreateMap<UserPost, EditUserPostEditModel>().ReverseMap();
        }
    }
}
