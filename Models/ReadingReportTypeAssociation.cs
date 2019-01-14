using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Models
{
    public class ReadingReportTypeAssociation
    {
        public Guid ReportID { get; set; }
        public string ReportTypeID { get; set; }
        public string UserId { get; set; }
        public string ParnterId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
