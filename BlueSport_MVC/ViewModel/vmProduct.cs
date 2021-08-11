using BlueSport_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.ViewModel
{
    public class vmProduct : vmCommon
    {
        public ProductModel urlProduct { get; set; }
        public List<ProductModel> lsProduct { get; set; }
    }
}
