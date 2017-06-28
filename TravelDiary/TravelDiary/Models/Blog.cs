using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDiary.Models
{
   public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }
        public string Rate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
