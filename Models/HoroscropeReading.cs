using ckl.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class HoroscropeReading
    {
        public Guid Id { get; set; }
        public int HorosopeId { get; set; }
        public string Title { get; set; }
        public string TypeId { get; set; }
        public string UserId { get; set; }
        public decimal BaseCost { get; set; }
        public bool IsSubscribed { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public string AdminId { get; set; }
        public string PartnerId { get; set; }
        public string Desciption { get; set; }
        public string BodyText { get; set; }
        public string Image { get; set; }
        public DateTime Created { get; set; }


    }
}
