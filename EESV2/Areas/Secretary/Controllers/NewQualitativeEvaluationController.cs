using EESV2.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EESV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class NewQualitativeEvaluationController : Controller
    {

        private readonly IUnitOfWork _uw;
        public NewQualitativeEvaluationController(IUnitOfWork uw)
        {
            _uw = uw;
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            NewQualityEvaluation newQualityEvaluation = _uw.NewQualityEvaluationRepository.Get(n => n.ID == id,include:s=>s
                                                                                                .Include(n=>n.Referral).ThenInclude(n=>n.Proposal))
                                                                                                .SingleOrDefault();
            if (newQualityEvaluation==null)
            {
                return BadRequest();
            }
            return View(newQualityEvaluation);
        }
    }
}
