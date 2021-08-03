using BlueSport_MVC.Models;
using BlueSport_MVC.ModelsDTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Service.Category
{
    public class CategoryService : ICategoryService
    {
        public List<BlueSport_MVC.Models.CategoryModel> GetCategories()
        {
            var data = new List<BlueSport_MVC.Models.CategoryModel>();

            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/category");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.CategoryDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 

            List<CategoryModel> categoryModels = new List<CategoryModel>();

            var parentCate = dataDto.Where(q => q.level == 0).ToList();
            var subCate = dataDto.Where(q => q.level == 1).ToList();
            var lastCate = dataDto.Where(q => q.level == 2).ToList();

            foreach (var item in parentCate)
            {
                //list category lever 0
                var listParent = item.ToGetCategory();
                listParent.subCate = new List<CategoryModel>();

                //List category lever 1
                var listSub = subCate.Where(s => s.parentid == listParent.CategoryID).ToList();
                foreach (var sub in listSub)
                {
                    var itemSub = sub.ToGetCategory();
                    itemSub.subCate = new List<CategoryModel>();
                    //List category lever 2
                    var listLast = lastCate.Where(a => a.parentid == sub.id).ToList();
                    foreach (var last in listLast)
                    {
                        itemSub.subCate.Add(last.ToGetCategory());
                    }
                    listParent.subCate.Add(itemSub);
                }
                categoryModels.Add(listParent);
            }

            #endregion

            #region Data
            return categoryModels;
            #endregion

            /* var data = new List<CategoryModel>();

             var parentCate = dataTest.Where(p => p.Level == 0).ToList();
             var subCate = dataTest.Where(p => p.Level == 1).ToList();
             var lastCate = dataTest.Where(p => p.Level == 2).ToList();

             foreach (var item in parentCate)
             {
                 var itemParent = new CategoryModel()
                 {
                     CategoryID = item.CategoryID,
                     CaretegoryName = item.CaretegoryName,
                     Level =item.Level,
                     subCate = new List<SubCategoryModel>(),
                 };
                 var SubCate = subCate.Where(b => b.ParendId == item.CategoryID).ToList();
                 foreach(var sub in SubCate)
                 {
                     var itemSub = new SubCategoryModel()
                     {
                         CategoryID = sub.CategoryID,
                         CategoryName = sub.CaretegoryName,
                         Level = sub.Level,
                         lastCate = new List<LastCategoryModel>()
                     };
                     var LastCate = lastCate.Where(c => c.ParendId == sub.CategoryID).ToList();
                     foreach(var last in LastCate)
                     {
                         itemSub.lastCate.Add(new LastCategoryModel()
                         {
                             CategoryID = last.CategoryID,
                             CategoryName = last.CaretegoryName,
                             Level =last.Level,
                         });
                     }
                     itemParent.subCate.Add(itemSub);
                 }
                 data.Add(itemParent);
             }

             return data;*/
            /*data.Add(new Models.CategoryModel()
            {
                CategoryID = 1,
                CaretegoryName = "Nam",
                Level = 0,
                subCate = new List<SubCategoryModel>()
                {
                    new SubCategoryModel()
                    {
                        CategoryID = 1,
                        CategoryName = "Giày dép",
                        lastCate = new List<LastCategoryModel>()
                        {
                            new LastCategoryModel()
                            {
                                CategoryID = 1,
                                CategoryName = "Xem tất cả giày dép"
                            },
                            new LastCategoryModel()
                            {
                                CategoryID = 1,
                                CategoryName = "Adidas"
                            }
                        }
                    },
                    new SubCategoryModel()
                    {
                        CategoryID = 2,
                        CategoryName = "Phụ kiện"
                    },
                    new SubCategoryModel()
                    {
                        CategoryID = 3,
                        CategoryName = "Áo - quần",
                        lastCate = new List<LastCategoryModel>()
                        {
                            new LastCategoryModel()
                            {
                                CategoryID = 1,
                                CategoryName = "Xem tất cả giày dép"
                            },
                            new LastCategoryModel()
                            {
                                CategoryID = 1,
                                CategoryName = "Adidas"
                            }
                        }
                    }
                },
            });
            data.Add(new Models.CategoryModel()
            {
                CategoryID = 2,
                CaretegoryName = "Nữ",
                subCate = new List<SubCategoryModel>()
                {
                    new SubCategoryModel()
                    {
                        CategoryID = 1,
                        CategoryName = "Giày dép",
                        lastCate = new List<LastCategoryModel>()
                        {
                            new LastCategoryModel()
                            {
                                CategoryID = 1,
                                CategoryName = "Adidas"
                            },
                            new LastCategoryModel()
                            {
                                CategoryID = 2,
                                CategoryName = "Puma"
                            },
                        }
                    },
                    new SubCategoryModel()
                    {
                        CategoryID = 2,
                        CategoryName = "Giày dép",
                        lastCate = new List<LastCategoryModel>()
                            {
                                new LastCategoryModel()
                                {
                                    CategoryID = 1,
                                    CategoryName = "Adidas"
                                },
                                new LastCategoryModel()
                                {
                                    CategoryID = 2,
                                    CategoryName = "Puma"
                                },
                            }
                    },
                    new SubCategoryModel()
                    {
                        CategoryID = 3,
                        CategoryName = "Giày dép"
                    }
                },
            });
            data.Add(new Models.CategoryModel()
            {
                CategoryID = 3,
                CaretegoryName = "Trẻ em",
                subCate = new List<SubCategoryModel>()
                {
                    new SubCategoryModel()
                    {
                        CategoryID = 1,
                        CategoryName = "Giày dép"
                    },
                    new SubCategoryModel()
                    {
                        CategoryID = 2,
                        CategoryName = "Giày dép"
                    },
                       new SubCategoryModel()
                    {
                        CategoryID = 3,
                        CategoryName = "Giày dép"
                    }
                },
            });
            data.Add(new Models.CategoryModel()
            {
                CategoryID = 4,
                CaretegoryName = "Thương hiệu",
                subCate = new List<SubCategoryModel>()
                {
                    new SubCategoryModel()
                    {
                        CategoryID = 1,
                        CategoryName = "Giày dép"
                    },
                    new SubCategoryModel()
                    {
                        CategoryID = 2,
                        CategoryName = "Áo - quần"
                    },
                    new SubCategoryModel()
                    {
                        CategoryID = 3,
                        CategoryName = "Phụ kiện"
                    }
                },
            });
            data.Add(new Models.CategoryModel()
            {
                CategoryID = 5,
                CaretegoryName = "Môn thể thao",
                subCate = new List<SubCategoryModel>()
                {
                    new SubCategoryModel()
                    {
                        CategoryID = 1,
                        CategoryName = "Giày dép",
                        lastCate = new List<LastCategoryModel>()
                        {
                            new LastCategoryModel()
                            {
                                CategoryID = 1,
                                CategoryName = "Test1"
                            },
                            new LastCategoryModel()
                            {
                                CategoryID = 1,
                                CategoryName = "Test1"
                            },
                        }

                    },
                    new SubCategoryModel()
                    {
                        CategoryID = 2,
                        CategoryName = "Giày dép"
                    },
                    new SubCategoryModel()
                    {
                        CategoryID = 3,
                        CategoryName = "Giày dép",
                        lastCate = new List<LastCategoryModel>()
                        {
                            new LastCategoryModel()
                            {
                                CategoryID = 1,
                                CategoryName = "Adidas"
                            },
                            new LastCategoryModel()
                            {
                                CategoryID = 1,
                                CategoryName = "Puma"
                            },
                        }
                    }
                },
            });
            data.Add(new Models.CategoryModel()
            {
                CategoryID = 6,
                CaretegoryName = "Phụ kiện thể thao",
            });
            return data;*/

        }
    }
}
