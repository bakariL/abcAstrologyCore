using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models.ViewModels
{
    public class HomeViewModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CustomerBio { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int CellPhoneNumber { get; set; }
        public int OtherPhoneNumber { get; set; }
        public string Image { get; set; }
        public decimal BaseCost { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime BeginningDateofBirth { get; set; }
        public DateTime EndingDateofBirth { get; set; }
        public string NewsLetterEmail { get; set; }
        public bool SignedUpforNewsletter { get; set; }
        public string Text { get; set; }
        public virtual SaturnReport SaturnReport { get; set; }
        public virtual Request Request { get; set; }
    }
}
