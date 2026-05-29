using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using FastRestaurant.Menu.Application.UseCases.Commands;
using FastRestaurant.Menu.Application.UseCases.Handlers;

namespace FastRestaurant.Menu.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // La URL en internet sera: api/dishes
    public class DishesController : ControllerBase
    {
        private readonly CreateDishHandler _createDishHandler;

        // Inyectamos el Handler
        public DishesController(CreateDishHandler createDishHandler)
        {
            _createDishHandler = createDishHandler;
        }

        [HttpPost] // Metodo HTTP POST para enviar datos desde el Front
        public async Task<IActionResult> CreateDish([FromBody] CreateDishCommand command)
        {
            try
            {
                // Le pasamos la orden al Handler
                Guid dishId = await _createDishHandler.HandleAsync(command);
                
                // Si todo sale bien, devolvemos un estado 201 (Created) con el ID del nuevo plato
                return CreatedAtAction(nameof(CreateDish), new { id = dishId }, new { id = dishId, message = "Plato creado con éxito." });
            }
            catch (Exception ex)
            {
                // Si algo falla (ej: precio <= 0), devolvemos un error 400
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}