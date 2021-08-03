using BlueSport_MVC.Models;
using BlueSport_MVC.Service.Banner;
using BlueSport_MVC.Service.Store;
using BlueSport_MVC.Service.Category;
using BlueSport_MVC.Service.Commitment;
using BlueSport_MVC.Service.Brand;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlueSport_MVC.Service.Product;

namespace BlueSport_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBannerService _bannerService;
        private readonly IStoreService _storeService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ICommitmentService _commitmentService;
        private readonly IBrandService _brandService;
        public HomeController(ILogger<HomeController> logger, IBannerService bannerService, IStoreService storeService, 
            IProductService productService, ICategoryService categoryService, ICommitmentService commitmentService,
            IBrandService brandService)
        {
            _logger = logger;
            _bannerService = bannerService;
            _productService = productService;
            _storeService = storeService;
            _categoryService = categoryService;
            _brandService = brandService;
            _commitmentService = commitmentService;
        }

        public IActionResult Index()
        {
            var viewModelHome = new ViewModel.ViewModelHome()
            {
                lsBanner = _bannerService.GetBannerHeader(),
                lsProductAll = _productService.GetProductsAll(),
                lsProductMale = _productService.GetProductsMale(),
                lsProductFemale = _productService.GetProductsFemale(),
                lsProductChildren = _productService.GetProductsChildren(),
                lsProductBicycle = _productService.GetProductsBicycle(),
                lsProductSport = _productService.GetProductsSport(),
                lsStore = _storeService.GetStores(),
                lsCategory = _categoryService.GetCategories(),
                lsBannerFooter = _bannerService.GetBannerFooter(),
                lsCommitment = _commitmentService.GetCommitments(),
                lsBrand = _brandService.GetBrands(),

            };

            return View(viewModelHome);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
