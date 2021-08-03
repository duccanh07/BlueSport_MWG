using BlueSport_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Service.Brand
{
    public class BrandService : IBrandService
    {
        public List<BlueSport_MVC.Models.ListBrandModel> GetBrands()
        {
            var data = new List<Models.ListBrandModel>();
            data.Add(new Models.ListBrandModel()
            {
                BrandModel = new List<BrandModel>()
                        {
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu01.png",
                                ImageName = "thuong hieu",
                                width = 68,
                                height = 38
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu02.png",
                                ImageName = "thuong hieu",
                                width = 62,
                                height = 37
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu03.png",
                                ImageName = "thuong hieu",
                                width = 76,
                                height = 28
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu04.png",
                                ImageName = "thuong hieu",
                                width = 58,
                                height = 29
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu05.png",
                                ImageName = "thuong hieu",
                                width = 65,
                                height = 18
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu06.png",
                                ImageName = "thuong hieu",
                                width = 66,
                                height = 44
                            },
                        }
            });
            data.Add(new Models.ListBrandModel()
            {
                BrandModel = new List<BrandModel>()
                        {
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu02.png",
                                ImageName = "thuong hieu",
                                width = 68,
                                height = 38
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu03.png",
                                ImageName = "thuong hieu",
                                width = 62,
                                height = 37
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu01.png",
                                ImageName = "thuong hieu",
                                width = 76,
                                height = 28
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu06.png",
                                ImageName = "thuong hieu",
                                width = 58,
                                height = 29
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu05.png",
                                ImageName = "thuong hieu",
                                width = 65,
                                height = 18
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu04.png",
                                ImageName = "thuong hieu",
                                width = 66,
                                height = 44
                            },
                        }
            });
            data.Add(new Models.ListBrandModel()
            {
                BrandModel = new List<BrandModel>()
                        {
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu01.png",
                                ImageName = "thuong hieu",
                                width = 68,
                                height = 38
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu05.png",
                                ImageName = "thuong hieu",
                                width = 62,
                                height = 37
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu04.png",
                                ImageName = "thuong hieu",
                                width = 76,
                                height = 28
                            },

                        }
            });

            return data;
        }
    }
}
