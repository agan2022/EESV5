using AutoMapper;
using EESV2.DAL.EditModels;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using EESV2.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IUtilities _utilities;
        private readonly IMapper _mapper;
        public UserController(IUnitOfWork uw,IUtilities utilities,IMapper mapper)
        {
            _uw = uw;
            _utilities = utilities;
            _mapper = mapper;
        }

        public IActionResult GetUserByUserName(string userName)
        {
            var model = _uw.UserRepository.Get(u => u.Username == userName,include:s=>s
                                                .Include(u=>u.Office))
                                                .Select(u => new {
                                                    FirstName=u.FirstName,
                                                    LastName=u.LastName,
                                                    OfficeName=u.Office.Name,
                                                    UserName=u.Username
                                                }).SingleOrDefault();
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Users()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserEditModel model,IFormFile pic)
        {
            if (ModelState.IsValid)
            {
                if (await _uw.UserRepository.IsExistAsync(u=>u.Username==model.Username))
                {
                    ModelState.AddModelError("", "شماره پرسنلی از قبلا وجود دارد");
                    return View(model);
                }
                string photoName = string.Empty;
                if (pic!=null)
                {
                    photoName =await SavePersonnelPhoto(pic);
                }
                User user = _mapper.Map<User>(model);
                user.Pic = photoName;
                user.Password = _utilities.GetSHA512Hash(model.Password);
                user.CreateDate = _utilities.GetCurrentDateTime();
                _uw.UserRepository.Create(user);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Users");
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            User user = _uw.UserRepository.GetById(id);
            EditUserEditModel model= _mapper.Map<EditUserEditModel>(user);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserEditModel model,IFormFile Pic)
        {
            if (ModelState.IsValid)
            {
                string photoName = String.Empty;
                if (model.PictureState!=2)//اگر حذف تصویر نباشد
                {
                    if (Pic != null)
                    {
                        photoName = await SavePersonnelPhoto(Pic);
                    }
                }
                else
                {
                    photoName = _uw.UserRepository.Get(u => u.ID == model.ID).Select(u => u.Pic).SingleOrDefault();
                    RemovePersonnelPhoto(photoName);
                    photoName = String.Empty;
                }
                User user = _mapper.Map<User>(model);
                user.Password = (String.IsNullOrEmpty(model.Password)?user.Password:_utilities.GetSHA512Hash(model.Password));
                user.Pic = photoName;
                _uw.UserRepository.Update(user);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Users");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            ViewData["id"]= id;
            return View();
        }

        private async Task<string> SavePersonnelPhoto(IFormFile photo)
        {
            string randomName = Guid.NewGuid().ToString() + Path.GetExtension(photo.FileName);
            string path = Directory.GetCurrentDirectory() + "\\PersonnelPhotos\\" + randomName;
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                await photo.CopyToAsync(stream);
            }
            return randomName;
        }
        private void RemovePersonnelPhoto(string name)
        {
            try
            {
                if (!String.IsNullOrEmpty(name))
                {
                    string path = Directory.GetCurrentDirectory() + "\\PersonnelPhotos\\" + name;
                    FileInfo file = new FileInfo(path);
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
