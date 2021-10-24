using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string Tytle { get; set; }
        public DateTime time { get; set; }

        public int CategoryId { get; set; }


        public virtual Category Category { get; set; }
        public string Author { get; set; }
      
    }
}
