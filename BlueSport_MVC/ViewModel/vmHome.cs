using BlueSport_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.ViewModel
{
    public class vmHome : vmCommon
    {
        public List<BannerModel> lsBanner { get; set; }
        public List<StoreModel> lsStore { get; set; }
        public List<ProductModel> lsProductAll { get; set; }
        public List<BannerModel> lsBannerFooter { get; set; }
        public List<ProductModel> lsProductMale { get; set; }
        public List<ProductModel> lsProductFemale { get; set; }
        public List<ProductModel> lsProductChildren { get; set; }
        public List<ProductModel> lsProductBicycle { get; set; }
        public List<ProductModel> lsProductSport { get; set; }
        public List<ListBrandModel> lsBrand { get; internal set; }
    }
}
