using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class PartnerType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Partnertype { get; set; }
        public string UserId { get; set; }

    }
}