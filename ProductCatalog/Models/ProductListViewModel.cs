using System.Collections.Generic;

namespace ProductCatalog.Models
{
    

    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }

}
