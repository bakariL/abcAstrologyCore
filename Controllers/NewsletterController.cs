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
    public class NewsletterController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly INewsLetterRepository _newsletterRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IPartnerRepository _partnerRepository;

        public NewsletterController
            (
                 ApplicationDbContext context,
                 SignInManager<ApplicationUser> signInManager,
                 UserManager<ApplicationUser> userManager,
                 INewsLetterRepository newsletterRepository,
                 ICustomerRepository customerRepository,
                 IPartnerRepository partnerRepository
            )
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _newsletterRepository = newsletterRepository;
            _customerRepository = customerRepository;
            _partnerRepository = partnerRepository;
        }

        public IActionResult Index()
        {
            var model = new NewsletterViewModel();
            model.Newsletters = _newsletterRepository.GetNewsletters();

            //var items = from w in _warningRepository.GetWarnings().Where(x => (model.IsAllBrandsSelected == true || x.BrandId == model.BrandId))
            //            join b in _brandRepository.GetBrands() on w.BrandId equals b.Id
            //            select new WarningViewModel
            //   var model = from u in _customerRepository.GetAll().Where(x => x.FirstName == user.UserFirstname))

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Newsletter newsLetter)
        {
            _newsletterRepository.Add(newsLetter);

            return RedirectToAction("Index", "Admin");
        }

        public IActionResult Edit(Guid Id)
        {
            var model = _newsletterRepository.GetNewsletters()
                .Where(x => x.Id == Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, Newsletter newsletter)
        {
            var model = _newsletterRepository.GetNewsletters()
                .FirstOrDefault(x => id == x.Id);

            model.Title = newsletter.Title;
            model.Desciption = newsletter.Desciption;
            model.BodyText = newsletter.BodyText;

            _newsletterRepository.Update(model);
            _newsletterRepository.Save();

            return RedirectToAction("ViewAll", "Newsletter");
        }

        [HttpGet]
        public IActionResult Delete(Guid Id, string username)
        {
            var model = _newsletterRepository.GetNewsLetterById(Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Newsletter newsletter)
        {
            _newsletterRepository.Delete(newsletter);
           
            return RedirectToAction("ViewAll", "Newsletter");
        }

        [HttpGet]
        public IActionResult Details(Newsletter newsletter)
        {
            var model = _newsletterRepository.GetNewsletters()
                 .Where(x => newsletter.Id == x.Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(int? id, Newsletter newsletter)
        {
            var news = _newsletterRepository.GetNewsletters()
                  .FirstOrDefault(x => x.Id == newsletter.Id);
            _newsletterRepository.Update(news);

            return RedirectToAction("Index", "Admin");
        }

        public IActionResult ViewAll()
        {
            var model = new NewsletterViewModel();
            model.Newsletters = _newsletterRepository.GetNewsletters();

            return View(model);
        }
    }
}
