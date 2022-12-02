using AutoMapper;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using EESV2.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Controllers
{
    [Authorize]
    public class SurveyController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IUtilities _utilities;
        private readonly IMapper _mapper;
        public SurveyController(IUnitOfWork uw,IUtilities utilities,IMapper mapper)
        {
            _uw = uw;
            _utilities = utilities;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSurveyViewModel model)
        {
            if (ModelState.IsValid)
            {
                int userID = _uw.UserRepository.Get(u=>u.Username==User.Identity.Name).Select(u=>u.ID).SingleOrDefault();
                Survey survey = _mapper.Map<Survey>(model);

                survey.Date = _utilities.GetDate();
                survey.UserID = userID;
                _uw.SurveyRepository.Create(survey);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Create", "Proposal");
            }
            return View(model);
        }
    }
}
