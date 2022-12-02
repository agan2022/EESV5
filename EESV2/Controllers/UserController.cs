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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        private readonly IUtilities _utilities;
        public UserController(IUnitOfWork uw, IMapper mapper, IUtilities utilities)
        {
            _uw = uw;
            _mapper = mapper;
            _utilities = utilities;
        }
        [HttpGet]
        public IActionResult Edit()
        {
            User user = _uw.UserRepository.Get(u => u.Username == User.Identity.Name).SingleOrDefault();
            if (user == null)
            {
                return BadRequest();
            }
            EditUserByUserEditModel model = _mapper.Map<EditUserByUserEditModel>(user);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserByUserEditModel model, IFormFile Pic)
        {
            if (ModelState.IsValid)
            {
                User user = _uw.UserRepository.GetById(model.ID);
                if (user == null)
                {
                    return BadRequest();
                }
                if (user.Username != User.Identity.Name)
                {
                    return BadRequest();
                }
                string photoName = String.Empty;
                if (model.PictureState != 2)//اگر حذف تصویر نباشد
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
                model.Pic = photoName;
                user = _mapper.Map(model, user);
                _uw.UserRepository.Update(user);
                await _uw.SaveChangesAsync();
                return Redirect("/Messages/SuccessOperation");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordByUserEditModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _uw.UserRepository.Get(u => u.Username == User.Identity.Name).SingleOrDefault();
                if (user == null)
                {
                    return BadRequest();
                }
                var data = Encoding.UTF8.GetBytes(model.OldPassword);
                string hash = "";
                using (SHA512Managed sha = new SHA512Managed())
                {
                    var bytes = sha.ComputeHash(data);
                    hash = BitConverter.ToString(bytes).Replace("-", String.Empty);
                }
                if (user.Password.ToLower() != hash.ToLower())
                {
                    ModelState.AddModelError("", "رمز عبور فعلی اشتباه است");
                    return View(model);
                }
                data = Encoding.UTF8.GetBytes(model.NewPassword);
                hash = "";
                using (SHA512Managed sha = new SHA512Managed())
                {
                    var bytes = sha.ComputeHash(data);
                    hash = BitConverter.ToString(bytes).Replace("-", String.Empty);
                }
                user.Password = hash;
                _uw.UserRepository.Update(user);
                await _uw.SaveChangesAsync();
                return Redirect("/Messages/SuccessOperation");
            }
            return View(model);
        }
        public IActionResult GetUserByUserName(string userName)
        {
            var user = _uw.UserRepository.Get(u => u.Username == userName, include: s => s
                                                  .Include(u => u.Office))
                                                .Select(u => new
                                                {
                                                    ID = u.ID
                                                                     ,
                                                    Username = u.Username
                                                                     ,
                                                    FirstName = u.FirstName
                                                                     ,
                                                    LastName = u.LastName
                                                                     ,
                                                    officeName = u.Office.Name
                                                }).SingleOrDefault();
            return Ok(new { id = user.ID, userName = user.Username, firstName = user.FirstName, lastName = user.LastName, officeName = user.officeName });
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

        [AllowAnonymous]
        public IActionResult GetPersonnelPhoto(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            User user = _uw.UserRepository.GetById(id);
            if (user == null)
            {
                return BadRequest();
            }
            string path = Directory.GetCurrentDirectory() + "\\PersonnelPhotos\\" + user.Pic;
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    byte[] data = new byte[fs.Length];
                    fs.Read(data, 0, data.Length);
                    return File(data, "	image/jpeg");
                }
            }
            catch (Exception ex)
            {
                return Ok("");
            }
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
