using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Models
{
    public class ListImageModel
    {
        public String ImageUrl { get; set; }
        public String ImageName { get; set; }

        public Boolean ActiveImage { get; set; }
    }
}
