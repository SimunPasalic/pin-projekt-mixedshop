using Microsoft.AspNetCore.Mvc;
using MixedShop.Models;
using MixedShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Components
{
    public class ShoppingCartSummary:ViewComponent
    {
        private readonly ShoppingCart _shopoingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shopoingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shopoingCart.GetShoppingCartItems();
            

            _shopoingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shopoingCart,
                ShoppingCartTotal = _shopoingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
