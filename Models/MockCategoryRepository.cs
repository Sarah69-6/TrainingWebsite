using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingWebsite.Models.ViewModels;

namespace TrainingWebsite.Models

{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>

            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Personalised Clothing", Description="Personalise Any Item of clothing for any occasion"},
                new Category{CategoryId=2, CategoryName="Personalised Soft Toys", Description="Personalise Any Soft Toy for any occasion"},
                new Category{CategoryId=3, CategoryName="Personalised Storage", Description="Personalise Any Item of storage for any item"},
                new Category{CategoryId=4, CategoryName="Personalised Ornaments", Description="Personalise Any Ornament for any occasion"}
            };
    }
}