using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.ViewComponents
{
    public class HomeSaturnReportViewComponent : ViewComponent
    {
        private readonly ISaturnReportRepository _saturnReportRepository;

        public HomeSaturnReportViewComponent(ISaturnReportRepository saturnReportRepository)
        {
            _saturnReportRepository = saturnReportRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(SaturnReportViewModel model)
        {
            var _model =  model ?? new SaturnReportViewModel();

            return View(_model);
        }
    }
}
