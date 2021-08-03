using BlueSport_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Service.Store
{
    public interface IStoreService
    {
        public List<StoreModel> GetStores();
    }
}
