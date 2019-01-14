using ckl.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class SaturnReport
    {
        public Guid Id { get; set; }
        public int SaturnReportId { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
        public string PartnerId { get; set; }
        public string FileId { get; set; }
        public int UserIntId { get; set; }
        public decimal BaseCost { get; set; }
        public string UserName { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime BeginningDateofBirth { get; set; }
        public DateTime EndingDateofBirth { get; set; }
        public string DOB { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserGender { get; set; }
        public string UserEmail { get; set; }
        public string Desciption { get; set; }
        public string BodyText { get; set; }
        public string Image { get; set; }
        public bool IsSubscribed { get; set; }
        public DateTime Created { get; set; }


        [NotMapped]
        public virtual ICollection<Customer> CustomersList { get; set; }
        [NotMapped]
        public virtual ICollection<Partner> PartnerList{ get; set; }

    }
}
