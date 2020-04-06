using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TrainingWebsite.Models

{
    public interface IProductRepository

    {
        IEnumerable<Products> AllProducts { get; }
        IEnumerable<Products> ProductsOfTheWeek { get; }
        Products GetProductById(int productId);
    }

}