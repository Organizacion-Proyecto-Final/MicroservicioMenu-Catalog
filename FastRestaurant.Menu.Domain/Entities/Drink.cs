using System;

namespace FastRestaurant.Menu.Domain.Entities
{
    public class Drink
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}