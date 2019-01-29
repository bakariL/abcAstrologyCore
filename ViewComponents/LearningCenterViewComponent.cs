using ckl.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.ViewComponents
{
    public class LearningCenterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(HomeViewModel model)
        {
            var _model = model ?? new HomeViewModel();
            return View(_model);
        }
    }
}
