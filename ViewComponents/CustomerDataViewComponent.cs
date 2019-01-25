using ckl.Models;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.ViewComponents
{
    public class CustomerDataViewComponent : ViewComponent
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerDataViewComponent(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(CustomerViewModel model)
        {
            var _model = model ?? new CustomerViewModel();
            _model.Customers = _customerRepository.GetAll();
            _model.CustomerCount = _customerRepository.GetAll().Count();
            
            
            return View(_model);
        }

    }
}
