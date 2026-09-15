var builder = WebApplication.CreateBuilder(args);

// 1. Agregamos los servicios de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 2. Activamos Swagger para que tenga su propia ruta técnica
app.UseSwagger();
app.UseSwaggerUI();

// 3. Activamos los archivos estáticos y por defecto (para que cargue tu index.html en la raíz "/")
app.UseDefaultFiles();
app.UseStaticFiles();

// 4. Tu lista en memoria con datos iniciales
var listaScouts = new List<Scout>
{
    new Scout("Carlos Pérez", 15, "Tropa"),
    new Scout("Ana Gómez", 12, "Lobatos")
};

// 5. Endpoints de la API
app.MapGet("/scouts", () => listaScouts);

app.MapPost("/scouts", (Scout nuevoScout) =>
{
    listaScouts.Add(nuevoScout);
    return Results.Created($"/scouts/{nuevoScout.Nombre}", nuevoScout);
});

app.Run();

record Scout(string Nombre, int Edad, string Rama);