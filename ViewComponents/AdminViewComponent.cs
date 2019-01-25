using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.ViewComponents
{
    public class AdminViewComponent : ViewComponent
    {
        private readonly IHoroscopeRepository _horoscopeRepository;
        private readonly ISaturnReportRepository _saturnReportRepository;
        private readonly INewsLetterRepository _newsLetterRepository;
        private readonly ICustomerRepository _customerRepository;

        public AdminViewComponent(
            IHoroscopeRepository horoscopeRepository, 
            ISaturnReportRepository saturnReportRepository, 
            INewsLetterRepository newsLetterRepository,
            ICustomerRepository customerRepository
            )
        {
            _horoscopeRepository = horoscopeRepository;
            _saturnReportRepository = saturnReportRepository;
            _newsLetterRepository = newsLetterRepository;
            _customerRepository = customerRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(AdminViewModel model)
        {
            var _model = model ?? new AdminViewModel();
            //show all users
            _model.Customers = _customerRepository.GetAll();
            //show total user count
            //show user added/joined todays
            //show users joined the week
            //show users joined this month
            //show most recent newsletter published 
            //show saturn report request number
            return View(_model);
        }
    }
}
