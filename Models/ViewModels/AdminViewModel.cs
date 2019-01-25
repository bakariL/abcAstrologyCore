using ckl.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models.ViewModels
{
    public class AdminViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminUserName { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string CustomerEmail { get; set; }
        public string AdminImage { get; set; }
        public int CustomerId { get; set; }
        public int CustomerCount { get; set; }
        [Display(Name = "Status")]
        public bool IsActive { get; set; }
        [Display(Name = "Registion Date")]
        public DateTime SignUPDate { get; set; }
        public decimal BaseCost { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime BeginningDateofBirth { get; set; }
        public DateTime EndingDateofBirth { get; set; }
        public int SaturnReportCount { get; set; }
        public int SaturnReportsRequested { get; set; }
        public int SaturnReportsSent { get; set; }
        public int ReadingsCount { get; set; }
        public int ReadingSent { get; set; }
        public int RedaingsRequest { get; set; }
        public int SaturnReportsCount { get; set; }
        public int NewsletterSubscribersCount { get; set; }
        public int NewslettersCreated { get; set; }
        public int NewslettersSent { get; set; }
        [Display(Name = "First Name")]
        public string CustomerFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string CustomerLastName { get; set; }
        public DateTime RegiterDate { get; set; }
        public DateTime DOB { get; set; }
        public DateTime? DOBwithTime { get; set; }
        public string Text { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ApplicationUser User { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<SaturnReport> SaturnReports { get; set; }   
        public IEnumerable<Newsletter> Newsletters { get; set; }
        public IEnumerable<HoroscropeReading> HoroscropeReadings { get; set; }
        public IEnumerable<SelectListItem> CustomerList { get; set; }
        public IEnumerable<SelectListItem> SaturnReportsList { get; set; }
        public IEnumerable<SelectListItem> HoroscropReadingsList { get; set; }
        public IEnumerable<SelectListItem> NewslettersList { get; set; }



    }
}
