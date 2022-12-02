using AutoMapper;
using EESV2.DAL.EditModels;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class CommitteeController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        public CommitteeController(IUnitOfWork uw,IMapper mapper)
        {
            _uw = uw;
            _mapper = mapper;
        }
        


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCommitteeEditModel model)
        {
            if (ModelState.IsValid)
            {
                Committee committee = _mapper.Map<Committee>(model);
                _uw.CommitteeRepository.Create(committee);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var committee = _uw.CommitteeRepository.GetById(id);
            EditCommitteeEditModel model = _mapper.Map<EditCommitteeEditModel>(committee);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCommitteeEditModel model)
        {
            if (ModelState.IsValid)
            {
                Committee committee = _uw.CommitteeRepository.GetById(model.ID);
                if (committee==null)
                {
                    return BadRequest();
                }
                if (model.SecretaryID!=-1)
                {
                    UserCommittee userCommittee = _uw.UserCommitteeRepository.Get(uc => uc.CommitteeID == model.ID && uc.UserId == model.SecretaryID)
                                                            .SingleOrDefault();
                    if (userCommittee == null)
                    {
                        return BadRequest();
                    }
                    _uw.UserCommitteeRepository.Delete(userCommittee);
                    UserCommittee userCommittee2 = new UserCommittee()
                    {
                        CommitteeID = committee.ID,
                        UserId = committee.SecretaryID
                    };
                    _uw.UserCommitteeRepository.Create(userCommittee2);
                }
                else
                {
                    model.SecretaryID = committee.SecretaryID;
                }
                committee = _mapper.Map(model, committee);
                _uw.CommitteeRepository.Update(committee);
                await _uw.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            //چک میکنیم که کمیته عضوی نداشته باشد
            var membersCount = _uw.UserCommitteeRepository.Count(uc => uc.CommitteeID == id);
            if (membersCount!=0)
            {
                TempData["Alert"] = "حذف به دلیل داشتن عضو ممکن نیست.";
                return RedirectToAction("Index");
            }
            _uw.CommitteeRepository.DeleteById(id);
            await _uw.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Members(int id)
        {
            ViewData["id"] = id;
            return View();
        }

        [HttpGet]
        public IActionResult AddMember(int id)//id of committee
        {
            AddMembersToCommitteeEditModel model = new AddMembersToCommitteeEditModel()
            {
                ID = id
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddMember(AddMembersToCommitteeEditModel model)
        {
            if (ModelState.IsValid)
            {
                int[] userIDs = _uw.UserCommitteeRepository.Get(uc => uc.CommitteeID == model.ID).Select(uc=>uc.UserId).ToArray();
                List<UserCommittee> newUserCommittees = new List<UserCommittee>();
                foreach (var userID in model.MembersIDs)
                {
                    //چک میکنیم یوزر جدید قبلا عضو نبوده باشد
                    if (!userIDs.Contains(userID))
                    {
                        UserCommittee uc = new UserCommittee();
                        uc.CommitteeID = model.ID;
                        uc.UserId = userID;
                        newUserCommittees.Add(uc);
                    }
                }
                _uw.UserCommitteeRepository.Create(newUserCommittees);
                await _uw.SaveChangesAsync();
                return Redirect("/Secretary/Committee/Members?id="+model.ID);
            }
            return View(model);
        }
    }
}
