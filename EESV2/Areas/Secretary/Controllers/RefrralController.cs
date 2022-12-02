using AutoMapper;
using EESV2.DAL.EditModels;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class RefrralController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IUtilities _utilities;
        private readonly IMapper _mapper;
        public RefrralController(IUnitOfWork uw,IUtilities utilities,IMapper mapper)
        {
            _uw = uw;
            _utilities = utilities;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Create(int ProposalID)
        {
            CreateReferralEditModel model = new CreateReferralEditModel()
            {
                ProposalID = ProposalID
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateReferralEditModel model)
        {
            if (ModelState.IsValid)
            {
                int secretaryUserID = _uw.CommitteeRepository.Get(c => c.ID == model.CommitteeID&&c.StatusID==1).Select(c => c.SecretaryID).SingleOrDefault();
                int senderID =Convert.ToInt32(User.Claims.SingleOrDefault(c=>c.Type=="ID").Value);

                Referral referral = _mapper.Map<Referral>(model);
                referral.StatusID = 2;
                referral.Date = _utilities.GetDate();
                referral.Time = _utilities.GetTime();
                referral.IP = _utilities.GetUSRIP(HttpContext);
                referral.SenderID = senderID;
                referral.ReciverID = secretaryUserID;
                referral.Result = String.Empty;
                _uw.ReferralRepository.Create(referral);
                Proposal proposal = _uw.ProposalRepository.GetById(model.ProposalID);
                proposal.StatusID = 1;
                _uw.ProposalRepository.Update(proposal);
                await _uw.SaveChangesAsync();
                return Redirect("/Messages/SuccessOperation");
            }
            return View(model);
        }
    }
}
