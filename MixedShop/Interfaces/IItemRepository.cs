using MixedShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Item> Items { get;  }
        IEnumerable<Item> RecommendedItem { get; }

        Item GetItemById(int itemId);
    }
}
