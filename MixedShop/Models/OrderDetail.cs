using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }


        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
