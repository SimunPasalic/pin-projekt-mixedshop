using MixedShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
