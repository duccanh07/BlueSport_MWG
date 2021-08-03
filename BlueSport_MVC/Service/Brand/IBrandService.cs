using BlueSport_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Service.Brand
{
    public interface IBrandService
    {
        public List<ListBrandModel> GetBrands();
    }
}
