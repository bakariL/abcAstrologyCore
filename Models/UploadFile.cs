using ckl.Data;
using System;

namespace ckl.Models
{
    public class UploadFile
    {
        public Guid Id { get; set; }
        public string UploadedId { get; set; }
        public string FileSize { get; set; }
        public Byte Size { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string CustomerId { get; set; }
        public string PartnerId { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public DateTime MyProperty { get; set; }
        public string Description { get; set; }
        public byte[] Data { get; set; }
        public string DocumentLinkName { get; set; }
        public string DocumentLink { get; set; }

        public virtual ApplicationUser User { get; set; }
       


    }
}