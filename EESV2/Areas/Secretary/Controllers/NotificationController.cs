using EESV2.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EESV2.DAL.Entities;
using EESV2.DAL.ViewModels;
using EESV2.Utilities;
using EESV2.DAL.EditModels;
using AutoMapper;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class NotificationController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IUtilities _utilities;
        private readonly IMapper _mapper;

        public NotificationController(IUnitOfWork uw,IUtilities utilities,IMapper mapper)
        {
            _uw = uw;
            _utilities = utilities;
            _mapper = mapper;
        }
        public ActionResult Notifications()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateNotificationEditModel model)
        {
            if (ModelState.IsValid)
            {
                Notification notification = _mapper.Map<Notification>(model);
                notification.PublishedDateTime = _utilities.GetDate();
                _uw.NotificationRepository.Create(notification);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Notifications");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Notification notification = _uw.NotificationRepository.GetById(id);
            EditNotificationEditModel model = _mapper.Map<EditNotificationEditModel>(notification);
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(EditNotificationEditModel model)
        {
            if (ModelState.IsValid)
            {
                Notification notification = _mapper.Map<Notification>(model);
                notification.PublishedDateTime = _utilities.GetDate();
                _uw.NotificationRepository.Update(notification);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Notifications");
            }
            return View(model);
        }
        public async Task<ActionResult> Delete(int? id)
        {
            _uw.NotificationRepository.DeleteById(id);
            await _uw.SaveChangesAsync();
            return RedirectToAction("Notifications");
        }

    }
}
