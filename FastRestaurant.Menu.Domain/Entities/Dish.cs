using System;

namespace FastRestaurant.Menu.Domain.Entities
{
    public class Dish
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public string Image { get; set; } = string.Empty;
        public TimeSpan Duration { get; set; } // Representa el tiempo de preparación
        
        // Relación con Categoría
        public Guid CategoryId { get; set; }
    }
}