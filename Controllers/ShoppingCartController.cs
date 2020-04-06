using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainingWebsite.Models;
using TrainingWebsite.Models.ViewModels;

namespace TrainingWebsite.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProducts = _productRepository.AllProducts.FirstOrDefault(p => p.ProductId == productId);

            if (selectedProducts != null)
            {
                _shoppingCart.AddToCart(selectedProducts, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProducts = _productRepository.AllProducts.FirstOrDefault(p => p.ProductId == productId);

            if (selectedProducts != null)
            {
                _shoppingCart.RemoveFromCart(selectedProducts);
            }
            return RedirectToAction("Index");
        }
    }
}
