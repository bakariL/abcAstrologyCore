using ckl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class Request 
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string UniqueId { get; set; }
        public string Gender { get; set; }
        public string  UserFirstName { get; set; }
        public string  UserLastName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime  UserDOB { get; set; }
        public int UserZip { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string UserName { get; set; }
        public DateTime DateRequested { get; set; }
        public bool IsUser { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
