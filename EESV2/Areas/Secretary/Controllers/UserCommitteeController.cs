using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class UserCommitteeController : Controller
    {
        private readonly IUnitOfWork _uw;
        public UserCommitteeController(IUnitOfWork uw)
        {
            _uw = uw;
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            UserCommittee userCommittee = _uw.UserCommitteeRepository.GetById(id);
            _uw.UserCommitteeRepository.Delete(userCommittee);
            await _uw.SaveChangesAsync();
            return Redirect("/Secretary/Committee/Members?id=" + userCommittee.CommitteeID);
        }
    }
}
