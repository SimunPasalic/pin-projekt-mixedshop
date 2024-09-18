using Microsoft.EntityFrameworkCore;
using MixedShop.Interfaces;
using MixedShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;
        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Item> Items { get { return _appDbContext.Item.Include(c => c.Category); } }
        public IEnumerable<Item> RecommendedItem { get { return _appDbContext.Item.Include(c => c.Category).Where(p => p.IsRecommended); } }

        public Item GetItemById(int itemId)
        {
            return _appDbContext.Item.FirstOrDefault(p => p.ItemId == itemId);
        }
    }
}
