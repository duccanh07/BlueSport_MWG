using BlueSport_MVC.Models;
using BlueSport_MVC.ModelsDTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Service.Store
{
    public class StoreService : IStoreService
    {
        public List<StoreModel> GetStores()
        {
            // to do call api 

            var data = new List<BlueSport_MVC.Models.StoreModel>();


            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/store");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.StoreDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 


            List<StoreModel> storeModels = new List<StoreModel>();
            foreach (var item in dataDto)
            {
                storeModels.Add(item.ToGetStore());
            }
            #endregion

            #region Data
            return storeModels;
            #endregion

            //var data = new List<Models.VisitModel>();
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport hàng xanh",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 1",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 2",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 3",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 4",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 5",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 6",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});

            //return data;
        }
    }
}
