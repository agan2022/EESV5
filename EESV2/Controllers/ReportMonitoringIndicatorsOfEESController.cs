using EESV2.DAL.ViewModels;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EESV2.DAL.ViewModels.ReportMonitoringIndicatorsOfEES;

namespace EESV2.Controllers
{
    [Authorize]
    public class ReportMonitoringIndicatorsOfEESController : Controller
    {
        private readonly IUnitOfWork _uw;
        public ReportMonitoringIndicatorsOfEESController(IUnitOfWork uw)
        {
            _uw = uw;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ReportMonitoringIndicatorsOfEESViewModel model)
        {

            if (ModelState.IsValid)
            {
                List<string> dateOFProposals = _uw.ProposalRepository.Get(p => EF.Functions.Like(p.Date, model.getYear().ToString("000#")+"/%")&&model.OfficeIDs.Contains(p.Registrar.OfficeID)).Select(p=>p.Date).ToList() ;

                model.Months = new List<int>();
                for (int i = 0; i < 12; i++)
                {
                    model.Months.Add(dateOFProposals.Where(d=> d.Contains("/"+ (i + 1).ToString("0#")+"/")).Count());
                }
                model.Days = new List<int>();
                for (int i = 0; i < 31; i++)
                {
                    model.Days.Add(dateOFProposals.Where(d => d.Contains("/" + model.getMonth().ToString("0#") + "/"+ (i + 1).ToString("0#"))).Count());
                }

                ViewData["viewModel"] = model;
            }
            return View(model);
        }
    }
}
