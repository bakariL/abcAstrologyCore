﻿using ckl.Areas.Identity.Services;
using ckl.Data;
using ckl.Extentions;
using ckl.Models;
using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace ckl.Controllers
{
    public class AccountController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ISaturnReportRepository _saturnReportRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManger;
        private readonly IPartnerRepository _partnerRepository;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public AccountController(
            ISaturnReportRepository saturnReportRepository,
            ICustomerRepository customerRepository,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<AccountController> logger,
            IPartnerRepository partnerRepository,
            IEmailSender emailSender
            )
        {
            _saturnReportRepository = saturnReportRepository;
            _customerRepository = customerRepository;
            _userManager = userManager;
            _signInManger = signInManager;
            _partnerRepository = partnerRepository;
            _emailSender = emailSender;
            _logger = logger;

        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signout()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                // Redirect to home page if the user is authenticated.
                return RedirectToAction(nameof(AccountController.Logout), "Account");
            }
            else return new EmptyResult();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManger.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToAction(nameof(HomeController.AbcHome), "Home");
        }
    }
}
