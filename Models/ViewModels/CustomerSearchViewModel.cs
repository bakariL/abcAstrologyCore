using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models.ViewModels
{
    public class CustomerSearchViewModel
    {
        public string UserId { get; set; }
        public bool CustomerIsSelected { get; set; }
        public int CustomerId { get; set; }
        public IEnumerable<SelectListItem> CustomerSelectList { get; set; }
        public string Search { get; set; }
        public string Text { get; set; }

    }
}
