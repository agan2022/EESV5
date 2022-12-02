using AutoMapper;
using EESV2.DAL.EditModels;
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

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class ImpartController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        private readonly IUtilities _utilities;
        public ImpartController(IUnitOfWork uw,IMapper mapper,IUtilities utilities)
        {
            _uw = uw;
            _mapper = mapper;
            _utilities = utilities;
        }


        [HttpGet]
        public IActionResult Imparts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EstimationCostForm(int ImpartID)
        {
            Impart impart = _uw.ImpartRepository.GetById(ImpartID);
            if (impart==null)
            {
                return BadRequest();
            }
            SecretaryEstimationCostFormEditModel model = _mapper.Map<SecretaryEstimationCostFormEditModel>(impart);
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> EstimationCostForm(SecretaryEstimationCostFormEditModel model)
        {
            if (ModelState.IsValid)
            {
                Impart impart = _uw.ImpartRepository.GetById(model.ID);
                impart.ImpartStatusID = model.ImpartStatusID;
                _uw.ImpartRepository.Update(impart);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Imparts");
            }
            return View(model);
        }





        [HttpGet]
        public IActionResult CreateImparts(int? proposalID)
        {
            if (proposalID!=null)
            {
                CreateImpartBySecretaryEditModel model = new CreateImpartBySecretaryEditModel()
                {
                    ProposalID = (int)proposalID
                };
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateImparts(List<CreateImpartBySecretaryEditModel> models)
        {
            List<Impart> imparts = new List<Impart>();
            foreach (var model in models)
            {
                Impart impart = new Impart()
                {
                    ExecutorID = _uw.UserRepository.Get(u=>u.Username==model.UserName).Select(u=>u.ID).SingleOrDefault(),
                    ProposalID = model.ProposalID,
                    ImpartStatusID = 1,//ای دی یک برای وضعیت نامشخص است برای اطلاع از وضعیت ها به دیتابیس رجوع شود
                    Date = _utilities.GetDate(),
                    Time = _utilities.GetTime(),
                };
                if (!imparts.Contains(impart))
                {
                    imparts.Add(impart);
                }
                Proposal p = _uw.ProposalRepository.GetById(model.ProposalID);
                p.StatusID = 9;
                _uw.ProposalRepository.Update(p);
            }
            _uw.ImpartRepository.Create(imparts);
            await _uw.SaveChangesAsync();
            return Redirect("/Messages/SuccessOperation");
        }


        public IActionResult TemporaryRegistration(CreateImpartBySecretaryEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return Ok();
            }
            var user = _uw.UserRepository.Get(u=>u.Username==model.UserName,include:s=>s
                                                .Include(u=>u.Office))
                                                .Select(u=>new { FirstName=u.FirstName,LastName=u.LastName,OfficeID=u.OfficeID,OfficeName=u.Office.Name, UserName =u.Username})
                                                .SingleOrDefault();
            return Ok(new { Fname = user.FirstName, Lname = user.LastName, UnitID = user.OfficeID, Unit = user.OfficeName, UserName = user.UserName, ProposalID = model.ProposalID });
        }
    }
}
