using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models
{



    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category Name is required")]
        public string CategoryName { get; set; }

        public ICollection<Product>? Products { get; set; }
    }


}
