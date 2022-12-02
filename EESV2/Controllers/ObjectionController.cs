using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using EESV2.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Controllers
{
    [Authorize]
    public class ObjectionController : Controller
    {
        IUnitOfWork _uw;
        IUtilities _utilities;
        public ObjectionController(IUnitOfWork uw,IUtilities utilities)
        {
            _uw = uw;
            _utilities = utilities;
        }

        [HttpGet]
        public IActionResult Create(int proposalID)
        {
            ViewData["proposalID"] = proposalID;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewObjectionViewModel model)
        {
            Proposal proposal = _uw.ProposalRepository.Get(p => p.ID == model.ProposalID && p.Registrar.Username == User.Identity.Name, include: s => s
                                                  .Include(p => p.Objections)
                                                  .Include(p=>p.Registrar))
                                                  .SingleOrDefault();
            if (proposal == null)
            {
                return BadRequest();
            }
            ViewData["proposal"] = proposal;

            if (ModelState.IsValid)
            {
                if (proposal.Objections.Count!=0)
                {
                    return BadRequest();
                }
                Objection objection = new Objection()
                {
                    Date = _utilities.GetDate(),
                    IP = _utilities.GetUSRIP(HttpContext),
                    Time = _utilities.GetTime(),
                    ProposalID = proposal.ID,
                    Reasons = model.Reasons,
                    UserID = proposal.Registrar.ID,
                };
                _uw.ObjectionRepository.Create(objection);
                await _uw.SaveChangesAsync();
                return Redirect("/Objection/Create?proposalID="+proposal.ID);
            }
            return View(model);
        }
    }
}
