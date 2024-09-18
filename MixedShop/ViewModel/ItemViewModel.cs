using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.ViewModel
{
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagelUrl { get; set; }
}
}
