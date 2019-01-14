using ckl.Data;
using ckl.Models;
using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Controllers
{
    public class HoroscopeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICustomerRepository _customerRepository;
        private readonly IPartnerRepository _partnerRepository;
        private readonly IHoroscopeRepository _horoscopeRepository;


        public HoroscopeController
            (
                ApplicationDbContext context,
                SignInManager<ApplicationUser> signInManager,
                UserManager<ApplicationUser> userManager,
                ICustomerRepository customerRepository,
                IPartnerRepository partnerRepository, 
                IHoroscopeRepository horoscopeRepository
            )
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _customerRepository = customerRepository;
            _partnerRepository = partnerRepository;
            _horoscopeRepository = horoscopeRepository;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(Guid Id)
        {
            var model = _horoscopeRepository.GetAll()
                .Where(x => Id == x.Id);
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(HoroscropeReading reading, Guid Id)
        {
            var horoscropeReading = _horoscopeRepository.GetAll()
                .FirstOrDefault(x => Id == x.Id);

            horoscropeReading.Title = reading.Title;
            horoscropeReading.Desciption = reading.Desciption;
            horoscropeReading.BodyText = reading.BodyText;
            horoscropeReading.Created = reading.Created;

            _horoscopeRepository.Update(horoscropeReading);
            _horoscopeRepository.Save();

            return RedirectToAction("ViewAll", "Horoscope");
        }

        [HttpPost]
        public IActionResult Update(HoroscropeReading reading, Guid Id)
        {
            var horoscope = _horoscopeRepository.GetAll()
                .FirstOrDefault(x => Id == x.Id);

            _horoscopeRepository.Update(horoscope);
            _horoscopeRepository.Save();

            return RedirectToAction("ViewAll", "Horoscope");
        }

        public  IActionResult ViewAll()
        {
            var model = new HoroscopeViewModel();
            model.HoroscropeReadings = _horoscopeRepository.GetAll();
            return View(model);
        }

        public IActionResult Details(Guid Id)
        {
            var model = _horoscopeRepository.GetAll()
                        .Where(x => Id == x.Id);

            return View(model);

        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new HoroscopeViewModel();
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
        public IActionResult Create(HoroscropeReading horoscrope)
        {
            _horoscopeRepository.Add(horoscrope);
            
            return RedirectToAction("ViewAll", "Horoscope");
        }

     
        public IActionResult Delete(Guid Id)
        {
            var horo = _horoscopeRepository.GetAll()
                .Where(x => Id == x.Id);
            return View(horo);
        }

        [HttpPost]
        public IActionResult Delete(HoroscropeReading horoscrope, Guid Id)
        {
            var reading = _horoscopeRepository.GetAll()
                .FirstOrDefault(x => Id == x.Id);
            _horoscopeRepository.Delete(reading);

            return RedirectToAction("ViewAll", "Horoscope");
        }

    }
}
