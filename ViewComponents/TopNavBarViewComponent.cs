using ckl.Areas.Identity.Pages.Account;
using ckl.Data;
using ckl.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;


namespace ckl.ViewComponents
{
    public class TopNavBarViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public TopNavBarViewComponent(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager
            )
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }


        public async Task<IViewComponentResult> InvokeAsync(LoginViewModel loginView)
        {
            var _model = loginView  ?? new LoginViewModel();
            return  View(_model);
        }
    }
}
