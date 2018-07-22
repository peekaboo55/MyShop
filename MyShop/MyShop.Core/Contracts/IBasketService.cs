﻿using MyShop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyShop.Core.Contracts
{
    public interface IBasketService
    {
        void AddtoBasket(HttpContextBase httpContext, string productId);
        void RemoveFormBasket(HttpContextBase httpContext, string itemId);
        List<BasketItemViewModel> GetBasketItem(HttpContextBase httpContext);
        BasketSummaryViewModel GetBasketSummary(HttpContextBase httpContext);
    }
}
