using System.Collections.Generic;

namespace OA1.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
