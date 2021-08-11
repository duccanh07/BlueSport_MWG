using BlueSport_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Service.Product
{
    public interface IProductService
    {
        public List<ProductModel> GetProductsAll();
        public List<ProductModel> GetProductsMale();
        public List<ProductModel> GetProductsFemale();
        public List<ProductModel> GetProductsChildren();
        public List<ProductModel> GetProductsBicycle();
        public List<ProductModel> GetProductsSport();
        public ProductModel GetUrl(string urlProduct);
    }
}
