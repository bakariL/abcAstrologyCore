using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string From { get; set; }
        public string cc { get; set; }
        public string Subject { get; set; }
        public string htmlMessage { get; set; }
        public string ServicePoint { get; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
