﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingWebsite.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Products> ProductsOfTheWeek { get; set; }
    }
}
