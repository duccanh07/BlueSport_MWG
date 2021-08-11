using BlueSport_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.ModelsDTO
{
    public class ProductDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string imageDetail { get; set; }
        public string priceCurrent { get; set; }
        public string priceOld { get; set; }
        public string saleOff { get; set; }
        public string brandName { get; set; }
        public string imageName { get; set; }
        public string installment { get; set; }
        public string imageBrand { get; set; }
        public string urlProduct { get; set; }
    }

    public static class ProductDTOExt
    {
        public static ProductModel ToGetProduct(this ProductDTO productDto)
        {
            return new ProductModel
            {
                NameProduct = productDto.name,
                ImageUrl = productDto.image,
                ImageBrand = productDto.imageBrand,
                PriceCurrent = productDto.priceCurrent,
                PriceOld = productDto.priceOld,
                Installment = productDto.installment,
                NameBrand = productDto.brandName,
                ImageName = productDto.imageName,
                Percent = productDto.saleOff,
                UrlProduct = productDto.ToGetUrlProduct(),
            };
        }

        public static string ToGetUrlProduct(this ProductDTO productDTO)
        {
            return string.IsNullOrEmpty(productDTO.urlProduct) ? productDTO.id : productDTO.urlProduct;
        }
        
    }
}
