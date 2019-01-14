using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class TextMsg
    {
        public int Id { get; set; }
        public int To { get; set; }
        public int From { get; set; }
        public string Message { get; set; }
    }
}
