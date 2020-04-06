using TrainingWebsite.Models;
using TrainingWebsite.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace TrainingWebsite.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    ProductListViewModel productListViewModel = new ProductListViewModel();

        //    productListViewModel.Products = _productRepository.AllProducts;
        //    productListViewModel.CurrentCategory = "Personalised Clothing";

        //    return View(productListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Products> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "All products";
            }
            else
            {
                products = _productRepository.AllProducts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var products = _productRepository.GetProductById(id);
            if(products == null)
                return NotFound();
            return View(products);
            
        }
    }

}