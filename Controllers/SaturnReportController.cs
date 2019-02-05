using ckl.Data;
using ckl.Models;
using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SignalRChat.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Controllers
{
    public class SaturnReportController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManger;
        private readonly ICustomerRepository _customerRepository;
        private readonly ISaturnReportRepository _saturnReportRepository;
        private readonly IPartnerRepository _partnerRepository;
        private readonly IRequestRepository _requestRepository;
        private readonly ChatHub _chatHub;

        public SaturnReportController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManger,
            ICustomerRepository customerRepository,
            ISaturnReportRepository saturnReportRepository,
            IPartnerRepository partnerRepository, 
            IRequestRepository requestRepository, 
            ChatHub chatHub
            )
        {
            _context = context;
            _userManager = userManager;
            _signInManger = signInManger;
            _customerRepository = customerRepository;
            _partnerRepository = partnerRepository;
            _saturnReportRepository = saturnReportRepository;
            _requestRepository = requestRepository;
            _chatHub = chatHub;
        }

        public IActionResult Index()
        {
            var model = new SaturnReportViewModel();
            model.SaturnReports = _saturnReportRepository.GetAllSaturnReports();
            return View(model);
        }

        public IActionResult Pending()
        {
            var model = new SaturnReportViewModel();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create(int? id)
        {
            var model = new SaturnReportViewModel();
            model.UserList = _customerRepository.GetAll()
                   .Select(x => new SelectListItem
                   {
                       Value = x.UserId.ToString(),
                       Text = x.UserName,
                       Selected = true

                   }).ToList();

            model.PartnerList = _partnerRepository.GetAllPartners()
                 .Select(x => new SelectListItem
                 {
                     Value = x.Id.ToString(),
                     Text = x.Email,
                     Selected = true,
                    
                 }).ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(SaturnReport report, int? id)
        {              
            _saturnReportRepository.Add(report);

            return RedirectToAction("ViewAll", "SaturnReport");
        }

        public IActionResult Edit(Guid id)
        {
            var model = _saturnReportRepository.GetAllSaturnReports()
                .Where(x => x.Id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(SaturnReport saturnReport, Guid Id)
        {
            var report = _saturnReportRepository.GetAllSaturnReports().FirstOrDefault(x => x.Id == Id);
            report.Title = saturnReport.Title;
            report.UserEmail = saturnReport.UserEmail;
            report.Desciption = saturnReport.Desciption;
            report.BodyText = saturnReport.BodyText;
            report.Created = saturnReport.Created;
           
            _saturnReportRepository.Update(report);
            _saturnReportRepository.Save();

            return RedirectToAction("Index", "Admin");
        }


        [HttpGet]
        public IActionResult Details(Guid Id)
        {
            var model = _saturnReportRepository.GetAllSaturnReports()
                 .Where(x => Id == x.Id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            if (ModelState.IsValid)
            {

                var report = _saturnReportRepository.GetAllSaturnReports()
                   .Where(x => x.Id == id);
                return View(report);
            }
            return NotFound();
        }


        [HttpPost]
        public IActionResult Delete(Guid id, SaturnReport saturnReport)
        {
            if (ModelState.IsValid)
            {
                var report = _saturnReportRepository.GetAllSaturnReports()
                   .FirstOrDefault(x => x.Id == id);
                _saturnReportRepository.Delete(report);
            }
            return RedirectToAction("ViewAll", "SaturnReport");
        }

     


        [HttpPost]
        public IActionResult Update(Guid id, SaturnReport saturn)
        {
            var report = _saturnReportRepository.GetAllSaturnReports()
                  .FirstOrDefault(x => x.Id == id);
            _saturnReportRepository.Update(report);

            return RedirectToAction("ViewAll", "SaturnReport");
        }

        public IActionResult ViewAll(int? id)
        {
            var model = new SaturnReportViewModel();
            model.SaturnReports = _saturnReportRepository.GetAllSaturnReports();
            return View(model);
        }

       
        public async Task<IActionResult> Request()
        {
            var request = new RequestViewModel();
          
            return View(request);
        }

        [HttpPost]
        public async Task<IActionResult> Request(RequestViewModel requestView)
        {

            var firstname = requestView.UserFirstName;
            var lastname = requestView.UserLastName;
            var email = requestView.Email;
            var dob = requestView.UserDOB;
            var gender = requestView.Gender;
         
           await _chatHub.SendMessage(firstname, lastname, dob, email, gender);
           return RedirectToAction("Index", "Admin");
        }



    }
}
