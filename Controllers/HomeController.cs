using ckl.Data;
using ckl.Extentions;
using ckl.Models;
using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ckl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ISaturnReportRepository _saturnReportRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManger;
        private readonly ApplicationDbContext _context;

        public HomeController(
            ApplicationDbContext context,
            ICustomerRepository customerRepository,
            ISaturnReportRepository saturnReportRepository,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager
            )
        {
            _context = context;
            _customerRepository = customerRepository;
            _saturnReportRepository = saturnReportRepository;
            _signInManger = signInManager;
            _userManager = userManager;
        }


        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId != null)
            {
                if (userId != null)
                {
                    ApplicationUser user = await _userManager.FindByIdAsync(userId);
                    if (await _userManager.IsInRoleAsync(user, "ADMIN"))
                    {
                        return RedirectPermanent("Admin/Index");
                    }

                    else if (await _userManager.IsInRoleAsync(user, "CUSTOMER"))
                    {
                        return RedirectPermanent("Customer/Index");
                    }
                    else
                        return RedirectPermanent("Home/AbcHome");

                }
            }
            return View();
        }

        public IActionResult Details()

        {
            var model = _customerRepository.GetAll()
             .Select(x => new Customer
             {
                 IsActive = x.IsActive,
                 Id = x.Id,
                 FirstName = x.FirstName,
                 LastName = x.LastName,
                 UserName = x.UserName,
                 Email = x.Email,
                 DOB = x.DOB,
                 DOBwithTime = x.DOBwithTime,
                 HoroscropeReadings = x.HoroscropeReadings,
                 SaturnReports = x.SaturnReports,
                 Newsletters = x.Newsletters

             }).ToList();
            return View(model);
        }

        public IActionResult Error()
        {
            var e = NotFound();
            return View(e);
               
        }

        public IActionResult AbcHome()
        {
            var model = new SaturnReport();
            return View(model);
        }

        [HttpPost]
        public IActionResult SaturnRequest()
        {
            //increase request count by 1. 
            return View();
        }

        public IActionResult Writer()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (StreamWriter sw = new StreamWriter(ms, Encoding.Unicode))
                {
                    // this is where you would loop through your data and add one line at a time
                    // for example...

                    // write header line
                    sw.WriteLine("sep=;");
                    sw.WriteLine(string.Join(";", new string[] { "Id", "FirstName", "LastName", "Email" }));
                    var items = from c in _customerRepository.GetAll()
                                select new AdminViewModel
                                {
                                    CustomerId = c.Id,
                                    CustomerFirstName = c.FirstName,
                                    CustomerLastName = c.LastName,
                                };
                    // loop through the list of objects you are trying to output to csv
                    foreach (var item in items)
                    {
                        sw.WriteLine(string.Join(";", new string[] { item.CustomerFirstName, item.CustomerLastName, Regex.Replace(item.Text, "\r|\n", string.Empty) }));
                    }
                }

                string fileName = "CustomersAll";
                string date = DateTime.Now.ToString("yyyy-MM-dd'T'hh:mm:ss");
                return File(ms.ToArray(), "text/csv", string.Format("{0}-{1}.csv", fileName, date));
            }
        }
    }
}



