using ckl.Data;
using ckl.Extentions;
using ckl.Models;
using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public CustomerController(
            ApplicationDbContext context,
            ICustomerRepository customerRepository,
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager
            )
        {
            _context = context;
            _customerRepository = customerRepository;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index(ApplicationUser user)
        {
            var id = _userManager.GetUserId(HttpContext.User);
            var currentUser = _userManager.FindByIdAsync(id);

            if (ModelState.IsValid)
            {
                if (user != null)
                {
                    var model = new CustomerViewModel();
                    model.Customers = _customerRepository.GetAll()
                        .Where(x => x.UserId == id);
                     
                    return View(model);

                }
                else
                {
                    return new EmptyResult();
                }   
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = _customerRepository.GetAll()
                .Where(x => x.Id == id);
              
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer, int? Id)
        {
            
                    var cust = _customerRepository.GetAll().FirstOrDefault(x => x.Id == Id);
                    cust.FirstName = customer.FirstName;
                    cust.LastName = customer.LastName;
                    cust.UserName = customer.UserName;
                    cust.Email = customer.Email;

                    _customerRepository.Update(cust);
                    _customerRepository.Save();
                 
            return RedirectToAction( "Index", "Admin");
        }



        [HttpPost]
        public IActionResult Update(int? id, Customer customer)
        {
            var user = _customerRepository.GetAll()
                  .FirstOrDefault(x => x.Id == customer.Id);
            _customerRepository.Update(user);

            return RedirectToAction("Index", "Admin");
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Customer model)
        {
            if (ModelState.IsValid)
            {
                _customerRepository.Add(model);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(ModelState.IsValid)
            {
               
                 var user = _customerRepository.GetAll()
                    .Where(x => x.Id == id);
                return View(user);
            }
            return NotFound();
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var user = _customerRepository.GetAll()
                   .FirstOrDefault(x => x.Id == id );
                _customerRepository.Delete(user);
                _customerRepository.Update(user);
            }
            return RedirectToAction("Index", "Admin");
        }


        [HttpGet]
        public IActionResult Details(int? id)
        {
            var model = _customerRepository.GetAll()
                   .Where(x => x.Id == id);
            return View(model);
        }

        public IActionResult ViewAll(int? id)
        {
               var model = new CustomerViewModel();
            model.Customers = _customerRepository.GetAll();
            return View(model);
        }


        public async Task<ActionResult> GetCustomerGridItem(string search, string filter, string sort, string order, int limit, int offset, int customerId)
    {
        var customers = from c in _customerRepository.GetAll()
                        select new CustomerViewModel
                        {

                            Id = c.Id,
                            FirstName = c.FirstName,
                            LastName = c.LastName,
                            UserName = c.UserName
                        };
        return Content(await customers.ItemsToJson(filter, sort, order, limit, offset), "application/json");
    }



}
}
