using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.ViewComponents
{
    public class HoroscopeDataViewComponent : ViewComponent
    {
        private readonly IHoroscopeRepository _horoscopeRepository;

        public HoroscopeDataViewComponent(IHoroscopeRepository horoscopeRepository)
        {
            _horoscopeRepository = horoscopeRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(HoroscopeViewModel horoscopeViewModel)
        {
            var _model = horoscopeViewModel ?? new HoroscopeViewModel();
            return View(_model);
        }
    }
}
