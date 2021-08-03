using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Models
{
    public class CategoryModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int Level { get; set; }
        public int ParendId { get; set; }
        public List<CategoryModel> subCate { get; set; }
    }
}
