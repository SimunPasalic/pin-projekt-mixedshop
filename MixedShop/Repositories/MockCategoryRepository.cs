using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MixedShop.Interfaces;
using MixedShop.Models;

namespace MixedShop.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1, CategoryName="Phone", Description="opis"},
                    new Category{CategoryId=2, CategoryName="Keyboard", Description="opis"},
                    new Category{CategoryId=3, CategoryName="Mouse", Description="opis"}
                };
            }
        }
    }
}
