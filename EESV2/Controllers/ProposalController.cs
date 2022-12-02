using AutoMapper;
using EESV2.DAL.EditModels;
using EESV2.DAL.Entities;
using EESV2.DAL.Services;
using EESV2.DAL.ViewModels;
using EESV2.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EESV2.Controllers
{
    [Authorize]
    public class ProposalController : Controller
    {
        private readonly IUnitOfWork _uw;
        private readonly IUtilities _utilities;
        private readonly IWebHostEnvironment _environment;
        private readonly IMapper _mapper;
        public ProposalController(IUnitOfWork uw
            ,IUtilities utilities
            , IWebHostEnvironment environment
            ,IMapper mapper)
        {
            _uw = uw;
            _utilities = utilities;
            _environment = environment;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            //چک میکنیم که آیا این کاربر امسال فرم نظر سنجی پر کرده است یا خیر
            bool isExist =await _uw.SurveyRepository.IsExistAsync(s=>s.User.Username==User.Identity.Name&&EF.Functions.Like(s.Date, _utilities.GetYearDate(0) + "%"));
            if (!isExist)
            {
                return RedirectToAction("Create","Survey");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProposalEditModel model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                Proposal proposal = _mapper.Map<Proposal>(model);
                proposal.StatusID = 4;//پیشنهاد با وضعیت در دست برسی
                proposal.Date = _utilities.GetDate();
                proposal.Time = _utilities.GetTime();
                proposal.IP = _utilities.GetUSRIP(HttpContext);
                proposal.RegistrarID = Convert.ToInt32(User.Claims.SingleOrDefault(c => c.Type == "ID").Value);
                int sumOfParticipate = 0;
                List<Participant> participants = new List<Participant>();
                if (model.Helpers!=null)
                {
                    if (model.Helpers.Count >= 7)
                    {
                        ModelState.AddModelError("", "تعداد افراد ثبت کننده پیشنهاد نمیتواند بیشتر از هفت نفر باشد.");
                        return View(model);
                    }
                    sumOfParticipate = model.Helpers.Sum(h => h.Percent);
                    if (sumOfParticipate > 100 || sumOfParticipate < 0)
                    {
                        return BadRequest();
                    }
                    foreach (var helper in model.Helpers)
                    {
                        Participant participant = new Participant()
                        {
                            Percent = helper.Percent,
                            UserID = helper.UserID,
                            Proposal = proposal
                        };
                        participants.Add(participant);
                    }
                }
                proposal.RegistrarParticipatePercent = 100 - sumOfParticipate;

                //کوعری میگیریم تا ببینیم کمیته فعال باشد.
                var committee = _uw.CommitteeRepository.Get(c => c.ID == model.CommitteeID&&c.StatusID==1)
                                                                              .Select(c=>new { SecretaryID=c.SecretaryID, Name=c.Name })
                                                                              .SingleOrDefault();
                if (committee == null)
                {
                    return BadRequest();
                }


                //یک ارجا برای دبیرخانه ایجاد میکنیم
                Referral referral = new Referral()
                {
                    Description = "دبیر محترم لطفا پیشنهاد را به <span style='color:red'>" + committee.Name + "</span> جهت ارزیابی ارجاء دهید.",
                    Date = _utilities.GetDate(),
                    IP = _utilities.GetUSRIP(HttpContext),
                    Time = _utilities.GetTime(),
                    Result = "",
                    SenderID = proposal.RegistrarID,
                    ReciverID = committee.SecretaryID,
                    StatusID = 2,
                    Proposal=proposal
                };

                //اگر فایل انتخاب شده بود آنرا ذخیره میکنیم
                if (file != null)
                {
                    if (Path.GetExtension(file.FileName) != ".rar" && Path.GetExtension(file.FileName) != ".zip" && Path.GetExtension(file.FileName) != ".7z")
                    {
                        ModelState.AddModelError("", "پسوند فایل ضمیمه باید یکی از انواع zip،rar،7z باشد.");
                        return View(model);
                    }
                    if (file.Length / 1024 / 1024 > 10)
                    {
                        ModelState.AddModelError("", "حجم فایل حداکثر باید 10 مگابایت باشد .");
                        return View(model);
                    }
                    string randomName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string path = this._environment.ContentRootPath + "\\AttachmentFiles\\" + randomName;
                    using (Stream stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    proposal.File = randomName;
                }



                _uw.ProposalRepository.Create(proposal);
                _uw.ParticipantRepository.Create(participants);
                _uw.ReferralRepository.Create(referral);
                await _uw.SaveChangesAsync();
                return Redirect("/Messages/SuccessAddNewProposal?ProposalID=" + proposal.ID);
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Review(int proposalID)
        {
            //چک میکنیم فقط کاربری که پیشنهاد دهنده باشد یا مجری یا ارزیاب باشد بتواند پیشنهاد را ببیند
            bool isRecommenderOrExecutor = await _uw.ProposalRepository.IsExistAsync(p =>p.ID==proposalID&&(p.Registrar.Username == User.Identity.Name||p.Imparts.Any(i=>i.Executor.Username==User.Identity.Name)||p.Referrals.Any(r=>r.Reciver.Username==User.Identity.Name)));
            if (!isRecommenderOrExecutor)
            {
                return BadRequest();
            }
            ViewData["proposalID"] = proposalID;
            return View();
        }

        [HttpGet]
        public IActionResult Sent()
        {
            return View();
        }
        public IActionResult DownloadFile(int proposalID)
        {
            string fileName = _uw.ProposalRepository.Get(p => p.ID == proposalID)
                                                                    .Select(p=>p.File)
                                                                    .SingleOrDefault();
            string path = Directory.GetCurrentDirectory() + "\\AttachmentFiles\\" + fileName;
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    byte[] data = new byte[fs.Length];
                    fs.Read(data, 0, data.Length);
                    return File(data, "text/h323",fileName);
                }
            }
            catch (Exception ex)
            {
                return Redirect("/Messages/NotFoundFile");
            }
        }
    }
}
