
using AutoMapper;
using EESV2.DAL.EditModels;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Areas.Secretary.Controllers
{
    [Area("Secretary")]
    [Authorize(Roles = "Secretary")]
    public class UserPostController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        public UserPostController(IUnitOfWork uw,IMapper mapper)
        {
            _uw = uw;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult UserPosts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserPostEditModel model)
        {
            UserPost userPost = _mapper.Map<UserPost>(model);
            _uw.UserPostRepository.Create(userPost);
            await _uw.SaveChangesAsync();
            return RedirectToAction("UserPosts");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            UserPost userPost = _uw.UserPostRepository.GetById(id);
            if (userPost==null)
            {
                return BadRequest();
            }
            EditUserPostEditModel model = _mapper.Map<EditUserPostEditModel>(userPost);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserPostEditModel model)
        {
            UserPost userPost = _uw.UserPostRepository.GetById(model.ID);
            if (userPost == null)
            {
                return BadRequest();
            }
            userPost = _mapper.Map(model,userPost);
            _uw.UserPostRepository.Update(userPost);
            await _uw.SaveChangesAsync();
            return RedirectToAction("UserPosts");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            int countUsers = _uw.UserPostRepository.Get(up => up.ID == id).Select(up => up.Users.Count()).SingleOrDefault();
            if (countUsers!=0)
            {
                TempData["Alert"] = "حذف ممکن نیست زیرا افرادی در این دسته قرار دارند.";
                return RedirectToAction("UserPosts");
            }
            _uw.UserPostRepository.DeleteById(id);
            await _uw.SaveChangesAsync();
            return RedirectToAction("UserPosts");
        }
        [HttpGet]
        public IActionResult Members(int id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
