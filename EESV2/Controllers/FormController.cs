using AutoMapper;
using EESV2.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace EESV2.Controllers
{
    [Authorize]
    public class FormController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        public FormController(IMapper mapper,IUnitOfWork uw)
        {
            _mapper = mapper;
            _uw = uw;
        }
        [HttpGet]
        public IActionResult Forms()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(string id)
        {
            ViewData["id"] = id;
            return View();
        }
        [HttpGet]
        public IActionResult DownloadFrom(string id)
        {
            string fileName = id.Trim();
            string path = Directory.GetCurrentDirectory() + "\\Formes\\" + fileName + ".zip";
            try
            {
                using (FileStream fs = new FileStream(path.Trim(), FileMode.Open))
                {
                    byte[] data = new byte[fs.Length];
                    fs.Read(data, 0, data.Length);
                    return File(data, "text/h323", fileName + ".zip");
                }
            }
            catch (Exception ex)
            {
                return Ok("فایل مورد نظر پیدا نشد.");
            }
        }
    }
}
