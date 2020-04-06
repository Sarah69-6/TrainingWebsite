using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingWebsite.Models.ViewModels;

namespace TrainingWebsite.Models

{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}