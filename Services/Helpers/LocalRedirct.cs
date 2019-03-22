using Microsoft.AspNetCore.Mvc;
using ckl.Controllers;


namespace ckl.Services.Helpers 
{
  public class LocalRedirct : Controller
  {
      public IActionResult ReLogin(string redirectUrl)
      { 
         return LocalRedirect(redirectUrl);
      }

      private IActionResult RedirectToLocal(string returnUrl)
    {
    if (Url.IsLocalUrl(returnUrl))
      {
        return Redirect(returnUrl);
      }
    else
      {
        return RedirectToAction(nameof(HomeController.Index), "AbcHome");
      }
    }
  } 
}