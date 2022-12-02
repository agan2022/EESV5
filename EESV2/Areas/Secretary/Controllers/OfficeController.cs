using AutoMapper;
using EESV2.DAL.EditModels;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
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
    public class OfficeController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        public OfficeController(IUnitOfWork uw,IMapper mapper)
        {
            _uw = uw;
            _mapper = mapper;
        }
        public IActionResult Offices()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateOfficeEditModel model)
        {
            if (ModelState.IsValid)
            {
                Office office = _mapper.Map<Office>(model);
                _uw.OfficeRepository.Create(office);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Offices");
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Office office = _uw.OfficeRepository.Get(o => o.ID == id,include:s=>s
                                                        .Include(o=>o.ParrentOffice)).SingleOrDefault(); ;
            if (office==null)
            {
                return BadRequest();
            }
            EditOfficeViewModel model = _mapper.Map<EditOfficeViewModel>(office);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditOfficeViewModel model)
        {
            if (ModelState.IsValid)
            {
                Office office = _mapper.Map<Office>(model);
                _uw.OfficeRepository.Update(office);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Offices");
            }
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (_uw.OfficeRepository.Count(o=>o.ParrentOfficeID==id)>0)//چک میکنیم اداره زیر مجموعه نداشته باشد.
            {
                TempData["Alert"]="حذف اداره به دلیل داشتن زیرمجموعه ممکن نیست.";
                return RedirectToAction("Offices");
            }
            if (_uw.UserRepository.Count(u => u.OfficeID == id) > 0)//چک میکنیم اداره کارمند نداشته باشد.
            {
                TempData["Alert"] = "حذف اداره به دلیل داشتن کارمند ممکن نیست.";
                return RedirectToAction("Offices");
            }
            _uw.OfficeRepository.DeleteById(id);
            await _uw.SaveChangesAsync();
            return RedirectToAction("Offices");
        }
    }
}
