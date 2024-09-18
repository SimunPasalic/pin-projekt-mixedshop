using MixedShop.Interfaces;
using MixedShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;

        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            decimal totalPrice = 0M;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    ItemId = shoppingCartItem.Item.ItemId,
                    Order = order,
                    Price = shoppingCartItem.Item.Price,
                };
                totalPrice += orderDetail.Price * orderDetail.Amount;
                _appDbContext.OrderDetail.Add(orderDetail);
            }

            order.OrderTotal = totalPrice;
            _appDbContext.Order.Add(order);

            //await _appDbContext.SaveChanges();
        }
    }
}
