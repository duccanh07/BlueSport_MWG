using BlueSport_MVC.Models;
using BlueSport_MVC.ModelsDTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Service.Product
{
    public class ProductService : IProductService
    {
        public List<BlueSport_MVC.Models.ProductModel> GetProductsAll()
        {
            // to do call api 

            var data = new List<BlueSport_MVC.Models.ProductModel>();


            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/product");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.ProductDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 
            List<ProductModel> productModels = new List<ProductModel>();
            foreach (var item in dataDto)
            {
                productModels.Add(item.ToGetProduct());
            }
            #endregion

            #region Data
            return productModels;
            #endregion

        }
        public List<BlueSport_MVC.Models.ProductModel> GetProductsMale()
        {
            // to do call api 

            var data = new List<BlueSport_MVC.Models.ProductModel>();


            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/product");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.ProductDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 
            List<ProductModel> productModels = new List<ProductModel>();
            foreach (var item in dataDto)
            {
                productModels.Add(item.ToGetProduct());
            }
            #endregion

            #region Data
            return productModels;
            #endregion

            /*var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
               
            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
               
            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });
            return data;*/
        }
        public List<BlueSport_MVC.Models.ProductModel> GetProductsFemale()
        {
            var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            return data;
        }
        public List<BlueSport_MVC .Models.ProductModel> GetProductsChildren()
        {
            var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            return data;
        }
        public List<BlueSport_MVC.Models.ProductModel> GetProductsBicycle()
        {
            var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            return data;
        }
        public List<BlueSport_MVC.Models.ProductModel> GetProductsSport()
        {
            var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            return data;
        }
    }
}
