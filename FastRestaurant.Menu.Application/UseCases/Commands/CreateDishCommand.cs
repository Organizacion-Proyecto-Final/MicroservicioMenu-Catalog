using System;

namespace FastRestaurant.Menu.Application.UseCases.Commands
{
    public class CreateDishCommand
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } // Puede ser null
        public decimal Price { get; set; }
        public int EstimatedPreparationMinutes { get; set; }
        public string? ImageUrl { get; set; } // Puede ser null
    }
}