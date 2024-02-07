﻿using DINMovie.Data.Cart;
using Microsoft.AspNetCore.Mvc;

namespace DINMovie.Data.ViewComponents
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
