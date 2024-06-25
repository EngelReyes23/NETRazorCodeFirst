using System.ComponentModel.DataAnnotations;

namespace NETRazorCodeFirst.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public required string ProductName { get; set; }

        [Display(Name = "Product Description")]
        public required string ProductDescription { get; set; }

        [Display(Name = "Product Price")]
        public required double ProductPrice { get; set; }

        [Display(Name = "Product Quantity")]
        public required int ProductQuantity { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
    }
}
