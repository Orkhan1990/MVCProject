﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
   public class Writer
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public bool WriterStatus { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public List<Blog> Blogs { get; set; }
        public virtual ICollection<Message> SenderMesage { get; set; }
        public virtual ICollection<Message> ReceiverMessage { get; set; }


    }
}
