using BlueSport_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Service.Category
{
    public interface ICategoryService
    {
        public List<CategoryModel> GetCategories();
    }
}
