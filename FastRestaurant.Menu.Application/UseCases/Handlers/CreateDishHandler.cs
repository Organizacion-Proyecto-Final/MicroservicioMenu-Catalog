using System;
using System.Threading.Tasks;
using FastRestaurant.Menu.Domain.Entities;
using FastRestaurant.Menu.Domain.Interfaces;
using FastRestaurant.Menu.Application.UseCases.Commands;

namespace FastRestaurant.Menu.Application.UseCases.Handlers
{
    public class CreateDishHandler
    {
        private readonly IMenuRepository _repository;

        public CreateDishHandler(IMenuRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> HandleAsync(CreateDishCommand command)
        {
            // Validaciones basicas de negocio que te pide la tabla
            if (command.Price <= 0)
            {
                throw new Exception("El precio del plato debe ser mayor a 0.");
            }

            // Mapeo de los datos a la nueva estructura de la Entidad
            var newDish = new Dish
            {
                Id = Guid.NewGuid(), // Generamos la PK (uuid)
                CategoryId = command.CategoryId, // La FK a la categoria
                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                EstimatedPreparationMinutes = command.EstimatedPreparationMinutes,
                Available = true, // Arranca visible en el menu
                ImageUrl = command.ImageUrl,
                
                // Fechas de auditoria
                CreatedAt = DateTime.UtcNow, // Fecha y hora actual en formato estandar UTC
                UpdatedAt = null // Todavia no se edito, arranca en null
            };

            // Mandamos a guardar al repositorio
            await _repository.AddDishAsync(newDish);

            return newDish.Id;
        }
    }
}