using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.ViewComponents
{
    public class SaturnReportDataViewComponent : ViewComponent
    {
        private readonly ISaturnReportRepository _saturnReportRepository;

        public SaturnReportDataViewComponent(ISaturnReportRepository reportRepository)
        {
            _saturnReportRepository = reportRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(SaturnReportViewModel reportViewModel)
        {
            var _model = reportViewModel ?? new SaturnReportViewModel();
            return View(_model);
        }
    }
}
