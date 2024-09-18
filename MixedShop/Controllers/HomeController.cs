using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MixedShop.Interfaces;
using MixedShop.Models;
using MixedShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }


        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                RecommendedItem = _itemRepository.RecommendedItem
            };
            return View(homeViewModel);
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
