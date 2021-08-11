using System;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Service.Client
{
    public interface IClientService
    {
        public IRestResponse GetAPI(string path);
    }
}
