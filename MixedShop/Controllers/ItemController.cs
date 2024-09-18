using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MixedShop.Interfaces;
using MixedShop.ViewModel;
using MixedShop.Models;

namespace MixedShop.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult Listt(string category)
        {
            //ItemListViewModel itemListViewModel = new ItemListViewModel();
            //itemListViewModel.Items = _itemRepository.Items;
            //itemListViewModel.CurrentCategory = "Phone";

            //return View(itemListViewModel);
            IEnumerable<Item> items;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                items = _itemRepository.Items.OrderBy(p => p.ItemId);
                currentCategory = "All items";
            }
            else
            {
                items = _itemRepository.Items.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ItemId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new ItemListViewModel
            {
                Items = items,
                CurrentCategory = currentCategory

            });
        }

        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();

            return View(item);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
