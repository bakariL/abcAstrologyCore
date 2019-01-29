using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models.ViewModels
{
    public class NewsletterViewModel 
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string PartnerId { get; set; }
        public string UserFirstname { get; set; }
        public string AdminUserName { get; set; }
        public string AdminUserId { get; set; }
        public Guid NewsLeterGuid { get; set; }
        public decimal BaseCost { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime BeginningDateofBirth { get; set; }
        public DateTime EndingDateofBirth { get; set; }
        public string NewsletterId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string CoAuthor { get; set; }
        public string Desciption { get; set; }
        public DateTime PushlisedDateTime { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ImgUrl { get; set; }
        public string[] Images { get; set; }
        public string BodyText { get; set; }
        public bool IsLive { get; set; }
        public IEnumerable<SelectListItem> UserList { get; set; }
        public IQueryable<Newsletter> Newsletters { get; set; }
        public IEnumerable<SelectListItem> ListofNewsletters { get; set; }
        public IEnumerable<SelectListItem> PartnerList { get; set; }
    }
}
