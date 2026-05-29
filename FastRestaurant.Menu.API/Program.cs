using FastRestaurant.Menu.Application.UseCases.Handlers;

var builder = WebApplication.CreateBuilder(args);

// REGISTRO DE SERVICIOS (Contenedor de Dependencias)

// LINEA que dice a .NET que busque y habilite los controladores
builder.Services.AddControllers();

// Registrar el Handler de CQRS para que el DishesController lo pueda usar
builder.Services.AddScoped<CreateDishHandler>();

// Configuracion de Swagger (Herramienta para probar la API en desarrollo)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// CONFIGURACION DEL PIPELINE (Rutas y Middleware)

// Activa la pantalla de Swagger para hacer pruebas
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Mapea las rutas de los controladores (ej: api/dishes)
app.MapControllers();

app.Run();