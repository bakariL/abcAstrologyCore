using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models.ViewModels
{
    public class SaturnReportViewModel
    {
        public int Id { get; set; }
        public int SaturnReportId { get; set; }
        public string  AdminId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLaastName { get; set; }
        public string UserEmail { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Author { get; set; }
        public string CustomerId { get; set; }
        public string UserId { get; set; }
        public string PartnerId { get; set; }
        public int UserIntId { get; set; }
        public string FileId { get; set; }
        public string File { get; set; }
        public string FileName  { get; set; }
        public string UserName { get; set; }
        public string Desciption { get; set; }
        public decimal BaseCost { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime BeginningDateofBirth { get; set; }
        public DateTime EndingDateofBirth { get; set; }
        public string BodyText { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public string PartnerName { get; set; }
        public DateTime Created { get; set; }
        public IEnumerable<SelectListItem> UserList { get; set; }
        public IEnumerable<SelectListItem> PartnerList { get; set; }
        public IEnumerable<SelectListItem> SaturnSelectList { get; set; }
        public IEnumerable<SaturnReport> SaturnReports { get; set; }
    }
}
