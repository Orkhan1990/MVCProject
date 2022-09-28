using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
   public class NewsLetter
    {
        [Key]
        public int EmailID { get; set; }
        public string EmailAddress { get; set; }
        public bool  Status { get; set; }

    }
}
