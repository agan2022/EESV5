using AutoMapper;
using EESV2.DAL.EditModels;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class ApproveOrRejectProposalController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        public ApproveOrRejectProposalController(IUnitOfWork uw,IMapper mapper)
        {
            _uw = uw;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index(int? id)
        {
            ViewData["id"] = id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ApproveOrRejectProposalEditModel model)
        {
            if (ModelState.IsValid)
            {
                int[] validStatuses = {2,3,8};//تصویب یا رد یا اماده طرح در شورا
                if (!validStatuses.Contains(model.StatusID))
                {
                    return BadRequest();
                };
                Proposal proposal = _uw.ProposalRepository.GetById(model.ID);
                proposal.DesDabir = model.DesDabir;
                proposal.StatusID = model.StatusID;
                _uw.ProposalRepository.Update(proposal);
                await _uw.SaveChangesAsync();
                if (model.StatusID==2)
                {
                    return Redirect("/Secretary/Impart/CreateImparts?proposalID=" + proposal.ID);
                }
                return Redirect("/Messages/SuccessOperation");
            }
            return View(model);
        }
    }
}
