using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models.Writer
{
    public class AddWriterImage
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public bool WriterStatus { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
