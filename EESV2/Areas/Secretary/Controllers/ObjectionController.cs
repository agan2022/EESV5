using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class ObjectionController : Controller
    {
        IUnitOfWork _uw;
        public ObjectionController(IUnitOfWork uw)
        {
            _uw = uw;
        }
        public IActionResult Objections()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Answer(ObjectionAnswerViewModel model)
        {
            if (ModelState.IsValid)
            {
                Objection objection = _uw.ObjectionRepository.GetById(model.ObjectionID);
                if (objection == null)
                {
                    return BadRequest();
                }
                objection.Result = model.Result;
                _uw.ObjectionRepository.Update(objection);
                await _uw.SaveChangesAsync();
                return Ok(objection.ID);
            }
            return BadRequest();
        }
    }
}
