using System;

namespace FastRestaurant.Menu.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; } // PK
        public string Name { get; set; } = string.Empty; // UNIQUE 
        public string? Description { get; set; } = string.Empty; // Acepta null
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}