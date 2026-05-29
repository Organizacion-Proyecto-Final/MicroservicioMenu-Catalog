using System;

namespace FastRestaurant.Menu.Domain.Entities
{
    public class Drink
    {
        public Guid Id { get; set; } // PK
        public Guid CategoryId { get; set; } // FK Category.Id
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public decimal Price { get; set; } // Debe ser > 0
        public bool Available { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}