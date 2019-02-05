using ckl.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class Customer
    {     
        public int Id { get; set; }
        public string UserId { get; set; }
        public string PartnerId { get; set; }
        public bool IsSubscribed { get; set; }
        public int SaturnId { get; set; }
        public int HorescopeId { get; set; }
        public int NewsLetterId { get; set; }
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
        public string ImageFileName { get; set; }
        public byte[] ImageData { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public DateTime? DOBwithTime { get; set; }
        public bool HasFamily { get; set; }
        public string FileID  { get; set; }
        public bool ForMe { get; set; }
        public int NumberOfChildren { get; set; }
        public string  TitleinFamily { get; set; }
        public DateTime DateRegistered { get; set; }
        public virtual ICollection<SaturnReport> SaturnReports { get; set; }
        public virtual ICollection<HoroscropeReading> HoroscropeReadings { get; set; }
        public virtual ICollection<Newsletter> Newsletters { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Partner Partner { get; set; }

    }
}
