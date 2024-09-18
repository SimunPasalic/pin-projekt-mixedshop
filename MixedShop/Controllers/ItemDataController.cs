using Microsoft.AspNetCore.Mvc;
using MixedShop.Interfaces;
using MixedShop.Models;
using MixedShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Controllers
{
    [Route("api/[controller]")]
    public class ItemDataController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public ItemDataController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public IEnumerable<ItemViewModel> LoadMoreItems()
        {
            IEnumerable<Item> dbItems = null;

            dbItems = _itemRepository.Items.OrderBy(p => p.ItemId).Take(10); //broj

            List<ItemViewModel> items = new List<ItemViewModel>();

            foreach (var dbItem in dbItems)
            {
                items.Add(MapDbPieToPieViewModel(dbItem));
            }

            return items;
        }

        private ItemViewModel MapDbPieToPieViewModel(Item dbItem)
        {
            return new ItemViewModel()
            {
                ItemId = dbItem.ItemId,
                Name = dbItem.Name,
                Price = dbItem.Price,
                Description = dbItem.Description,
                ImagelUrl = dbItem.Description
            };
        }
    }
}
