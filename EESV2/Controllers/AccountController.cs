using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUnitOfWork _uw;
        private IConfiguration _configuration { get; set; }
        public AccountController(IUnitOfWork uw,IConfiguration configuration)
        {
            _uw = uw;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel Model)
        {
            if (ModelState.IsValid)
            {
                EESV2.DAL.Entities.User user =_uw.UserRepository.Get(u=>u.Username==Model.UserName,include:s=>s
                                                                        .Include(u=>u.UserRoles).ThenInclude(ur=>ur.Role))
                                                                        .SingleOrDefault();
                if (user != null)
                {
                    var data = Encoding.UTF8.GetBytes(Model.Password);
                    string hash = "";
                    using (SHA512Managed sha = new SHA512Managed())
                    {
                        var bytes = sha.ComputeHash(data);
                        hash = BitConverter.ToString(bytes).Replace("-", String.Empty);
                    }
                    if (user.Password.ToLower() == hash.ToLower())
                    {
                        if (user.StatusID==1)//1 is for active user     2 for retired user    3 for deactive user
                        {
                            List<Claim> claims = new List<Claim>();
                            claims.Add(new Claim(ClaimTypes.Name, user.Username));
                            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Username));
                            foreach (UserRole userRole in user.UserRoles)
                            {
                                claims.Add(new Claim(ClaimTypes.Role, userRole.Role.Title));
                                claims.Add(new Claim("Role", userRole.Role.Title));
                            }
                            claims.Add(new Claim("ID", user.ID.ToString())) ;
                            claims.Add(new Claim("pic", user.Pic));
                            claims.Add(new Claim("FullName", user.FirstName + " " + user.LastName));
                            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                            var principal = new ClaimsPrincipal(identity);
                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                            return Redirect("/Home/AdvanceDashboard");
                        }
                        ModelState.AddModelError("ErrorMessage", "نام کاربری غیر فعال یا بازنشسته شده است .");
                    }
                }
                ModelState.AddModelError("ErrorMessage", "نام کاربری یا رمز عبور صحیح نیست.");
            }
            return View(Model);
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
