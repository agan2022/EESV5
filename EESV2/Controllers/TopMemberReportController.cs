using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels.TopMemberReport;
using EESV2.DAL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EESV2.DAL.Services.Interfaces;

namespace EESV2.Controllers
{
    [Authorize]
    public class TopMemberReportController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IProposalRepository _proposalRepository;

        private IRankService _rankService;

        public TopMemberReportController(IUnitOfWork uw, IProposalRepository proposalRepository, IRankService rankService)
        {
            _uw = uw;
            _proposalRepository = proposalRepository;
            _rankService = rankService;
        }

        [HttpGet]
        public IActionResult TopMembers()
        {
            return View();
        }
            [HttpPost]
        public IActionResult TopMembers(TopMemberViewModel model)
        {
            if (ModelState.IsValid)
            {

                var userRank = _rankService.TopMembersRankCalculation(model);

                model.userRankViewModels=userRank;

                ViewData["viewModel"] = userRank;
            }
            return View(model);
        }
    }
}
