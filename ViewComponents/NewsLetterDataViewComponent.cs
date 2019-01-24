using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.ViewComponents
{
    public class NewsLetterDataViewComponent : ViewComponent
    {
        private readonly INewsLetterRepository _newsLetterRepository;

        public NewsLetterDataViewComponent(INewsLetterRepository newsLetterRepository)
        {
            _newsLetterRepository = newsLetterRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(NewsletterViewModel newsletterViewModel)
        {
            var _model = newsletterViewModel ?? new NewsletterViewModel();
            return View(_model);
        }
    }
}
