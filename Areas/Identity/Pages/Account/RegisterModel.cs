using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using ckl.Data;
using ckl.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ckl.Services.Repositories;
using System.Security.Claims;
using System.Text;
using ckl.Extentions;

namespace ckl.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly IRoleRepository _roleRepository;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ICustomerRepository _customerRepository;
        private readonly IPartnerRepository _partnerRepository;
        private readonly IPartnerTypeAssociationRepository _partnerTypeAssociationRepository;
        public RegisterModel(
            IRoleRepository roleRepository,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ICustomerRepository customerRepository,
            IPartnerRepository partnerRepository,
            IPartnerTypeAssociationRepository partnerTypeAssociationRepository
            )
        {
            _roleRepository = roleRepository;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _customerRepository = customerRepository;
            _partnerRepository = partnerRepository;
            _partnerTypeAssociationRepository = partnerTypeAssociationRepository;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }


        public async Task<IActionResult> OnPostAsync(string returnUrl = null, string partnerName = "default")
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { FirstName = Input.FirstName, LastName = Input.LastName, UserName = Input.Email, Email = Input.Email };
                var customer = new Customer() { FirstName = Input.FirstName, LastName = Input.LastName, UserName = Input.Email, Email = Input.Email };
                
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    
                 var role = await _userManager.AddToRoleAsync(user, "USER");
                 
                    //await _partnerRepository.Insert(new Partner
                    //{
                    //    PartnerId = user.Id,
                    //    FirstName = user.FirstName,
                    //    LastName = user.LastName,
                    //    Email = user.Email,
                    //});
                    //_partnerRepository.Save();

                    await _customerRepository.Insert(new Customer
                    {

                        UserId = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        UserName = user.UserName,
                        Email = user.Email,
                       // DateRegistered = DateTimeExtensions.EstNow()

                    });
                    _customerRepository.Save();
                    _logger.LogInformation("User created a new account with password.");

                    //associate the user with the default partner                  
                    //await _partnerTypeAssociationRepository.Insert(new PartnerTypeAssociation
                    //{
                    //    PartnerId = user.Id,
                    //    FirstName = user.FirstName,
                    //    LastName = user.LastName,
                    //    Email = user.Email,
                    //});
                    //_partnerTypeAssociationRepository.Save();


                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);

                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
