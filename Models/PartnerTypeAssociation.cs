using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class PartnerTypeAssociation
    {
        public Guid PartnerTypeId { get; set; }
        public string PartnerId { get; set; }
        public string TypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
