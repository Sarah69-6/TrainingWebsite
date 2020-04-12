using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TrainingWebsite.Models.ViewModels;

namespace TrainingWebsite.Models

{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        [MaxLength(50)]
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string ImageUrl { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string ImageThumbnailUrl { get; set; }
        public bool InStock { get; set; }
        public bool IsProductsOfTheWeek { get; set; }
        public int categoryId { get; set; }
        public Category Category { get; set; }
        [MaxLength(50)]
        public string Notes { get; set; }
    }

}