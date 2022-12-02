using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class BazrController : Controller
    {
        IWebHostEnvironment _environmen;
        public BazrController(IWebHostEnvironment Environmen)
        {
            _environmen = Environmen;
        }

        [HttpPost]
        public async Task<IActionResult> UploadBazrFile(IFormFile file)
        {
            try
            {
                if (file != null)
                {
                    if (Path.GetExtension(file.FileName) != ".pdf")
                    {
                        return Ok("لطفلا فایل pdf بارگزاری کنید.");
                    }
                    string fileName = "BazrFile" + Path.GetExtension(file.FileName);
                    string path = this._environmen.WebRootPath + "\\BazrFile\\" + fileName;
                    using (Stream stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    return Ok("فایل با موفقیت بارگزاری شد.");
                }
                return Ok("عملیات با خطا مواجه شد.");
            }
            catch (Exception)
            {
                return Ok("عملیات با خطا مواجه شد.");
            }

        }
    }
}
