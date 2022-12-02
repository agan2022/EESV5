using AutoMapper;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class SurveyController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        public SurveyController(IUnitOfWork uw,IMapper mapper)
        {
            _uw = uw;
            _mapper = mapper;
        }
        public IActionResult Surveys()
        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            Survey survey = _uw.SurveyRepository.Get(s => s.ID == id).SingleOrDefault();
            survey.IsSeenByAdmin = true;
            _uw.SurveyRepository.Update(survey);
            await _uw.SaveChangesAsync();
            DetailsSurveyViewModel model = _mapper.Map<DetailsSurveyViewModel>(survey);
            return View(model);
        }
    }
}
