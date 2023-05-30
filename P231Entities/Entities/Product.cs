using System.Security.Principal;

namespace P231Entities.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string SKU { get; set; } = null!;
        public double Price { get; set; }
    }
}
