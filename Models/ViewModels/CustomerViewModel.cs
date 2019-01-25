using ckl.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class CustomerViewModel
    {

        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Text { get; set; }
        public Guid SaturnId { get; set; }
        public Guid HorescopeId { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string Address { get; set; }
        public string AddressTwo { get; set; }
        public IEnumerable<SelectListItem> Country { get; set; }
        public IEnumerable<SelectListItem> State { get; set; }
        public int ZipCode { get; set; }
        public string BillingAddress { get; set; }
        public string BillingAddressTwo { get; set; }
        public IEnumerable<SelectListItem> BillingCountry { get; set; }
        public IEnumerable<SelectListItem> BillingState { get; set; }
        public int BillingZipCode { get; set; }
        public bool IsShipppingAddressSameAsBilling { get; set; }
        public bool InfoIsSaved { get; set; }
        public string PaymentType { get; set; }
        public string NameOnCard { get; set; }
        public string CCnumber { get; set; }
        public DateTime CCexpirationDate { get; set; }
        public int CVV { get; set; }
        public DateTime DOB { get; set; }
        public DateTime? DOBwithTime { get; set; }
        public int CustomerCount { get; set; }
        public int AddedThisMonth { get; set; }
        public ICollection<IdentityRole> UserIdentityRoles { get; set; }
        public IEnumerable<SaturnReport> SaturnReports { get; set; }
        public IEnumerable<HoroscropeReading> HoroscropeReadings { get; set; }
        public IEnumerable<Newsletter> Newsletters { get; set; }
        public IEnumerable<SelectListItem> CustomerList { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
