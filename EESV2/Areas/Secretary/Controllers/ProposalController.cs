using AutoMapper;
using EESV2.DAL.EditModels;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using EESV2.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles ="Secretary")]
    public class ProposalController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IUtilities _utilities;
        private readonly IMapper _mapper;
        public ProposalController(IUnitOfWork uw,IUtilities utilities,IMapper mapper)
        {
            _uw = uw;
            _mapper = mapper;
            _utilities = utilities;
        }

        public IActionResult Proposals(ProposalsViewModel model)
        {

            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Now;
            ViewData["ThisYear"] = pc.GetYear(dt).ToString();

            if (ModelState.IsValid)
            {
                return View(model);
            }
            model.FromDate = new List<string>();
            model.ToDate = new List<string>();
            model.ToDate.Add(pc.GetDayOfMonth(dt).ToString("0#"));
            model.ToDate.Add(pc.GetMonth(dt).ToString("0#"));
            model.ToDate.Add(pc.GetYear(dt).ToString("0#"));
            DateTime TenDaysAgo = DateTime.Now.AddDays(-10);
            model.FromDate.Add(pc.GetDayOfMonth(TenDaysAgo).ToString("0#"));
            model.FromDate.Add(pc.GetMonth(TenDaysAgo).ToString("0#"));
            model.FromDate.Add(pc.GetYear(TenDaysAgo).ToString("0#"));
            return View(model);
        }

        [HttpGet]
        public IActionResult Proposal(int proposalID)
        {
            Proposal proposal = _uw.ProposalRepository.GetById(proposalID);
            EditProposalEditModel model = _mapper.Map<EditProposalEditModel>(proposal);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Proposal(EditProposalEditModel model)
        {
            if (ModelState.IsValid)
            {
                Proposal proposal = _uw.ProposalRepository.GetById(model.ID);
                proposal=_mapper.Map(model,proposal);
                _uw.ProposalRepository.Update(proposal);
                await _uw.SaveChangesAsync();
            }
            return View(model);
        }

        public async Task<IActionResult> ApproveOrRejectProposal(ProposalRefrralsViewModel model)
        {
            Proposal proposal = _uw.ProposalRepository.GetById(model.ProposalID);
            proposal.DesDabir = model.DesDabir;
            proposal.StatusID = model.StatusID;
            await _uw.SaveChangesAsync();
            return RedirectToAction("SuccessOperation", "Messages");
        }



        [HttpGet]
        public IActionResult FilterProposalsByTarget()
        {
            FilterProposalsByTargetViewModel model = new FilterProposalsByTargetViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult FilterProposalsByTarget(FilterProposalsByTargetViewModel model)
        {
            return View(model);
        }
    }
}
