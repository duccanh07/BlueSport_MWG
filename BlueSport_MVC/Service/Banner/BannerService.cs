using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;
using BlueSport_MVC.Models;
using BlueSport_MVC.ModelsDTO;
using RestSharp;
using BlueSport_MVC.Service.Client;

namespace BlueSport_MVC.Service.Banner
{
    public class BannerService : IBannerService
    {
        private string path;
        private readonly IClientService _clientService;

        public BannerService(IClientService clientService)
        {
            _clientService = clientService;
        }

        public List<BannerModel> GetBannerHeader()
        {
           
            var data = new List<BlueSport_MVC.Models.BannerModel>();
            #region Get Data DTO => API
            path = "banner";
            var response = _clientService.GetAPI(path);
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
            path = "bannerfooter";
            var response = _clientService.GetAPI(path);
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