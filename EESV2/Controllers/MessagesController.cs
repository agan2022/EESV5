using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EESV2.Controllers
{
    [Authorize]
    public class MessagesController : Controller
    {
        public IActionResult SuccessAddNewProposal(string ProposalID)
        {
            ViewData["Message"] = ProposalID;
            return View();
        }

        public IActionResult SuccessOperation()
        {
            return View();
        }
        public IActionResult NotFoundFile()
        {
            return View();
        }
    }
}
