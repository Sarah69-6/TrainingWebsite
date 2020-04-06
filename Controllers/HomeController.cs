using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainingWebsite.Models;
using TrainingWebsite.Models.ViewModels;

namespace TrainingWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductsOfTheWeek = _productRepository.ProductsOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}