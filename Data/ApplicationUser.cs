using ckl.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        [Required]
        public Guid  PartnerId { get; set; }
        public string UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public bool IsTerminated { get; set; }
        public virtual ICollection<Connection> Connections { get; set; }
        public virtual ICollection<SaturnReport> SaturnReports { get; set; }
        public virtual ICollection<HoroscropeReading> HoroscropeReadings { get; set; }
        public virtual ICollection<Newsletter> Newsletters { get; set; }
        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set;}
    }
}
