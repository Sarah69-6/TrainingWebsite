using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingWebsite.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Products> AllProducts
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }
        }
        public IEnumerable<Products> ProductsOfTheWeek
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(p => p.IsProductsOfTheWeek);
            }
        }
        public Products GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
