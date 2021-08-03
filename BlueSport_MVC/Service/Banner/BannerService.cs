using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;
using BlueSport_MVC.Models;
using BlueSport_MVC.ModelsDTO;
using RestSharp;

namespace BlueSport_MVC.Service.Banner
{
    public class BannerService : IBannerService
    {
        
        public List<BannerModel> GetBannerHeader()
        {
            var data = new List<BlueSport_MVC.Models.BannerModel>();


            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/banner");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.BannerDTO>>(response.Content);
            #endregion

            List<BannerModel> bannerModels = new List<BannerModel>();
            
            //mapping
            foreach (var item in dataDto)
            {
                bannerModels.Add(item.ToBannerModel());
            }

            return bannerModels;
        }

        public List<BlueSport_MVC.Models.BannerModel> GetBannerFooter()
        {
            // to do call api 

            var data = new List<BlueSport_MVC.Models.BannerModel>();


            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/bannerfooter");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.BannerDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 

            List<BannerModel> bannerFooter = new List<BannerModel>();
            foreach (var item in dataDto)
            {
                bannerFooter.Add(item.ToBannerModel());
            }
            #endregion

            #region Data
            return bannerFooter;
            #endregion


            /* var data = new List<Models.BannerModel>();
             data.Add(new Models.BannerModel()
             {
                 ImageUrl = "./images/img_trademark.jpeg",
                 ImageTitle = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình",
                 Title = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình"
             });
             data.Add(new Models.BannerModel()
             {
                 ImageUrl = "./images/img_trademark.jpeg",
                 ImageTitle = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình",
                 Title = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình"
             });
             data.Add(new Models.BannerModel()
             {
                 ImageUrl = "./images/img_trademark.jpeg",
                 ImageTitle = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình",
                 Title = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình"
             });
             return data; */
        }

    }
}