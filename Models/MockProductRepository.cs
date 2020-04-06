using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingWebsite.Models
{ 
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();
        public IEnumerable<Products> AllProducts =>
              new List<Products>
              {
                   new Products {ProductId=1, ProductName="Personalised Baby Vest", Price=10.00M, ShortDescription="Create your own personalised baby vest"},
                   new Products {ProductId=2, ProductName="Personalised Make-up Bag", Price=10.00M, ShortDescription="Create your own personalised Make-up bag"},
                   new Products {ProductId=3, ProductName="Personalised Water Bottle", Price=10.00M, ShortDescription="Create your own personalised Water Bottle"},
                   new Products {ProductId=4, ProductName="Personalised Container ", Price=10.00M, ShortDescription="Create your own personalised Containers"}
              };

        public IEnumerable<Products> ProductsOfTheWeek => throw new NotImplementedException();

        public Products GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}