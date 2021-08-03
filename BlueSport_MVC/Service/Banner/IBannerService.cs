using System.Collections.Generic;
using BlueSport_MVC.ModelsDTO;
using BlueSport_MVC.Models;

namespace BlueSport_MVC.Service.Banner
{
    public interface IBannerService
    {
        public List<BannerModel> GetBannerHeader();
        public List<BannerModel> GetBannerFooter();
    }
}