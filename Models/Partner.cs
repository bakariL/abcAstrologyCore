using ckl.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class Partner
    {
        public Guid Id { get; set; }
        public int PartnerIntId { get; set; }
        public string TypeId { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PartnerId { get; set; }
        public int CustomerCount { get; set; }
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

        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<SaturnReport> SaturnReports { get; set; }
        public virtual ICollection<HoroscropeReading> HoroscropeReadings { get; set; }
        public virtual ICollection<Newsletter> Newsletters { get; set; }


    }
}
