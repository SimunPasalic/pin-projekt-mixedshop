using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Make { get; set; }

        [Column(TypeName = "decimal(18,2)")] 
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsRecommended { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
