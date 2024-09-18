using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MixedShop.Interfaces;
using MixedShop.Models;

namespace MixedShop.Repositories
{
    public class MockItemRepository : IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Item> Items
        { 
            get
            {
                return new List<Item>
                {
                    new Item {ItemId = 1, Name="prvi item", Price=10, IsRecommended=false, Make="make1", Description="testni podaci", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=1},
                    new Item {ItemId = 2, Name="drugi item", Price=10, IsRecommended=false, Make="make2", Description="testni podaci2", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=2},
                    new Item {ItemId = 8, Name="prvi item", Price=110, IsRecommended=false, Make="make1", Description="testni podaci3", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=3},
                    new Item {ItemId = 12, Name="drugi item", Price=310, IsRecommended=false, Make="make2", Description="testni podaci24", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=2},
                    new Item {ItemId = 1, Name="5 item", Price=10, IsRecommended=false, Make="make1", Description="testni podaci", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=1},
                    new Item {ItemId = 2, Name="7 item", Price=120, IsRecommended=false, Make="make2", Description="testni podaci2", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=3},
                    new Item {ItemId = 8, Name="8 item", Price=110, IsRecommended=false, Make="make1", Description="testni podaci3", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=3},
                    new Item {ItemId = 12, Name="9 item", Price=10, IsRecommended=false, Make="make2", Description="testni podaci24", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=1},
                    new Item {ItemId = 1, Name="prvi item", Price=10, IsRecommended=false, Make="make1", Description="testni podaci", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=1},
                    new Item {ItemId = 2, Name="drugi item", Price=10, IsRecommended=false, Make="make2", Description="testni podaci2", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=2},
                    new Item {ItemId = 8, Name="prvi item", Price=110, IsRecommended=false, Make="make1", Description="testni podaci3", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=3},
                    new Item {ItemId = 12, Name="drugi item", Price=310, IsRecommended=false, Make="make2", Description="testni podaci24", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=2},
                    new Item {ItemId = 1, Name="5 item", Price=10, IsRecommended=false, Make="make1", Description="testni podaci", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=1},
                    new Item {ItemId = 2, Name="7 item", Price=120, IsRecommended=false, Make="make2", Description="testni podaci2", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=3},
                    new Item {ItemId = 8, Name="8 item", Price=110, IsRecommended=false, Make="make1", Description="testni podaci3", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=3},
                    new Item {ItemId = 12, Name="9 item", Price=10, IsRecommended=false, Make="make2", Description="testni podaci24", ImageUrl="",ImageThumbnailUrl="",Category = _categoryRepository.Categories.ToList()[0],CategoryId=1}

                };
            } 
        }
        public IEnumerable<Item> RecommendedItem => throw new NotImplementedException();

        public Item GetItemById(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
