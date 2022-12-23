using EESV2.DAL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EESV2.DAL.Services.Interfaces;
using MD.PersianDateTime.Core;

namespace EESV2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IRankService _rankService;

        public HomeController(IRankService rankService)
        {
            _rankService = rankService;
        }

        public IActionResult Index(int Date)
        {
            if (Date == 0)
            { 
                PersianDateTime pr=new PersianDateTime(DateTime.Now);
                Date=pr.Year;
            }

            var model = _rankService.RankCalculation(null, Date, 0);

            return View(model);
        }
        public IActionResult AdvanceDashboard(AdvanceDashboardViewModel model)
        {
            return View(model);
        }
    }
}
