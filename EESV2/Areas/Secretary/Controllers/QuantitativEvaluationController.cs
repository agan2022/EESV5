using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class QuantitativEvaluationController : Controller
    {
        private readonly IUnitOfWork _uw;
        public QuantitativEvaluationController(IUnitOfWork uw)
        {
            _uw = uw;
        }
        public async Task<IActionResult> Review(int id)
        {
            QuantitativEvaluation model =await _uw.QuantitativEvaluationRepository.Get(q=>q.ID==id,include:s=>s
                                                                                    .Include(q=>q.Referral))
                                                                                    .SingleOrDefaultAsync();
            return View(model);
        }
    }
}
