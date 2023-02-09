﻿using EcommerceApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceApp.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
