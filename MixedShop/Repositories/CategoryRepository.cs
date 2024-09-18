using MixedShop.Interfaces;
using MixedShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Category;
    }
}
