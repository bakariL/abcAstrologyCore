using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ckl.Areas.Identity.Services;
using ckl.Data;
using ckl.Models;
using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Hubs;


namespace ckl.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ISaturnReportRepository _saturnReportRepository;
        private readonly IHoroscopeRepository _horoscopeRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;
        private readonly INewsLetterRepository _newsLetterRepository;
        private readonly IHubContext<ChatHub> _hubContext;
        private readonly IRequestRepository _requestRepository;
        private readonly ChatHub _chatHub;



        public AdminController(
            ApplicationDbContext context,
            ICustomerRepository customerRepository,
            INewsLetterRepository newsLetterRepository,
            ISaturnReportRepository saturnReportRepository,
            IHoroscopeRepository horoscopeRepository, 
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, 
            IEmailSender emailSender,
            IRequestRepository requestRepository,
            IHubContext<ChatHub> hubContext,
            ChatHub chatHub
            )
        {
            _context = context;
            _customerRepository = customerRepository;
            _saturnReportRepository = saturnReportRepository;
            _signInManger = signInManager;
            _userManager = userManager;
            _emailSender = emailSender;
            _horoscopeRepository = horoscopeRepository;
            _newsLetterRepository = newsLetterRepository;
            _requestRepository = requestRepository;
            _hubContext = hubContext;
            _chatHub = chatHub;
        }


        // GET: Admin
        public async Task<ActionResult> Index()
        {
            int requestNumber = 5;
            var model = new AdminViewModel();
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                if (userId != null)
                {
                    ApplicationUser user = await _userManager.FindByIdAsync(userId);

                    if (await _userManager.IsInRoleAsync(user, "ADMIN"))
                    {
                        model.NewsletterSubscribersCount = _newsLetterRepository.GetNewsletters().Count();
                        model.SaturnReportsCount = _saturnReportRepository.GetAllSaturnReports().Count();
                        model.ReadingsCount = _horoscopeRepository.GetAll().Count();
                        model.Customers = _customerRepository.GetAll();
                        model.SaturnReportsRequested = requestNumber;
                        model.SaturnReports = _saturnReportRepository.GetAllSaturnReports();
                        model.CustomerList = _customerRepository.GetAll()
                           .Select(x => new SelectListItem
                           {
                               Value = x.Id.ToString(),
                               Text = x.UserName
                           }).ToList();
                        model.Customers = _customerRepository.GetAll();
                    }
                    else if (await _userManager.IsInRoleAsync(user, "USER"))
                    {
                        return RedirectPermanent("Home/Index");
                    }
                }
                else
                {
                    return RedirectPermanent("/Pages/Account/Login");
                }
            }
            return View(model);
        }

        public IActionResult SaturnRequest(int? id)
        {
            var model = new RequestViewModel();
            model.RequestsIE = _requestRepository.GetAll();
            
            return View(model);
        }



        public IActionResult Send()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Send(string email, string subject, string body)
        {
            await _emailSender.SendEmailAsync(email, subject, body);
            return View();
        }
        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Calendar()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }

  
    }
}