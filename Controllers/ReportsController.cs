using ckl.Data;
using ckl.Models;
using ckl.Models.ViewModels;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace ckl.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ISaturnReportRepository _saturnReportRepository;
        private readonly ICustomerRepository _customerRepository;

        public ReportsController(ISaturnReportRepository saturnReportRepository, ICustomerRepository customerRepository,  ApplicationDbContext context)
        {
            _context = context;
            _saturnReportRepository = saturnReportRepository;
            _customerRepository = customerRepository;

        }
        public IActionResult Index()
        {
            // this is where you would loop through your data and add one line at a time
            // for example...

            // write header line
            //sw.WriteLine("sep=;");
            //sw.WriteLine(string.Join(";", new string[] { "Brand", "MFRItemNumber", "MASItemNumber", "Description", "Warning" }));
            //var items = from w in _warningRepository.GetWarnings().Where(x => (model.IsAllBrandsSelected == true || x.BrandId == model.BrandId))
            //            join b in _brandRepository.GetBrands() on w.BrandId equals b.Id
            //            select new WarningViewModel
            //            {
            //                Id = w.Id,
            //                BrandName = b.Name,
            //                MfrItemNumber = w.MfrItemNumber,
            //                MasItemNumber = w.MasItemNumber,
            //                ItemDescription = w.ItemDescription,
            //                Text = w.Text
            //            };
            //// loop through the list of objects you are trying to output to csv
            //foreach (var item in items)
            //{
            //    sw.WriteLine(string.Join(";", new string[] { item.BrandName, item.MfrItemNumber, item.MasItemNumber, item.ItemDescription, Regex.Replace(item.Text, "\r|\n", string.Empty) }));
            //}
            return View();
        }

        public IActionResult Create(int? id)
        {
            return View();
        }
    }
}

       // [HttpPost]
        //public IActionResult Create(SaturnReport saturnReport, string userName)
        //{
        //    //is user logged in
        //    if (ModelState.IsValid)
        //    {
        //        //if logged in, 
        //        //get current userId, 
        //        string userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        //        //get current username
        //        string currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name).Value;
        //        //get current role
        //        string currentRole = HttpContext.User.FindFirst(ClaimTypes.Role).Value;
        //        //get all saturn reports
        //        var report = _saturnReportRepository.GetAllSaturnReports()
        //            .Where(x => x.Id == saturnReport.Id);


        //        try
        //        {
        //            if(report != null)
        //            {
        //                //create saturn report
        //                //assign report to current user
        //            //  foreach(var x in )
                        
                        
                        
        //                //get current user 
        //                //get current saturn report
        //                //join them in the userfileAssociationtable                         
        //                _saturnReportRepository.Update(saturnReport);
        //            }
        //            else
        //            //{
        //            //    var item = _saturnReportRepository.Insert(new SaturnReport
        //            //    {
        //            //        UserGuid = Guid.NewGuid(),
        //            //        Id = saturnReport.Id,
        //            //        Title = saturnReport.Title,
        //            //        Desciption = saturnReport.Desciption,
        //            //        BodyText = saturnReport.BodyText,
        //            //        HostUser = saturnReport.HostUser
        //            //    });
        //            //    saturnReport.Id = item.Id;

        //            //    _userFileAssociationRepository.Add(new UserFileAssociation
        //            //    {
        //            //        UserId = saturnReport.UserGuid,
        //            //        FileId = saturnReport.Id

        //            //    });
        //            }
        //            _userFileAssociationRepository.Save();
        //        }
        //        catch (Exception ex)
        //        {
        //            RedirectToAction(ex.HelpLink);
        //        }
        //    }
           
        //    //
        //    return View();
        //}
      
    //}
//}
