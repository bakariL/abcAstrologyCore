using ckl.Data;
using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.ViewComponents
{
    public class TopPanelAdminViewComponent : ViewComponent
    {
        private readonly IHoroscopeRepository _horoscopeRepository;
        private readonly ISaturnReportRepository _saturnReportRepository;
        private readonly INewsLetterRepository _newsLetterRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public TopPanelAdminViewComponent(
            IHoroscopeRepository horoscopeRepository,
            ISaturnReportRepository saturnReportRepository,
            INewsLetterRepository newsLetterRepository,
            ICustomerRepository customerRepository,
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager
            )
        {
            _horoscopeRepository = horoscopeRepository;
            _saturnReportRepository = saturnReportRepository;
            _newsLetterRepository = newsLetterRepository;
            _customerRepository = customerRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(AdminViewModel model)
        {
            var _model = model ?? new AdminViewModel();

            _model.NewsletterSubscribersCount = _newsLetterRepository.GetNewsletters().Count();
            _model.ReadingsCount = _horoscopeRepository.GetAll().Count();
            _model.SaturnReportsCount = _saturnReportRepository.GetAllSaturnReports().Count();
            

            return View(_model);       
            
       }
    }
}
