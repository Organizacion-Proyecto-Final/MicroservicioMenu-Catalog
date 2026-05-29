using System;
using System.Threading.Tasks;
using FastRestaurant.Menu.Domain.Entities; // Esto es para que encontrar las Entities

namespace FastRestaurant.Menu.Domain.Interfaces
{
    public interface IMenuRepository
    {
        // Accion para agregar un plato a la base de datos
        Task AddDishAsync(Dish dish);

        // Accion para buscar si una categoria existe por su ID
        Task<Category?> GetCategoryByIdAsync(Guid id);
    }
}