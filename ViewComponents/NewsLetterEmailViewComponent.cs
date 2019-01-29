using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.ViewComponents
{
    public class NewsLetterEmailViewComponent : ViewComponent
    {
        private readonly INewsLetterRepository _newsLetterRepository;

        public NewsLetterEmailViewComponent(INewsLetterRepository newsLetterRepository)
        {
            _newsLetterRepository = newsLetterRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(NewsletterViewModel model)
        {
            var _model = model ?? new NewsletterViewModel();
            return View(_model);
        }
    }
}
