using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapPost("/analizar", ([FromBody] SoftwareRequest request) =>
{
    var resultados = new[] {
        "El software {request.Nombre} es una aplicaci�n de ejemplo.",
        "El software {request.Nombre} es una herramienta �til para la gesti�n de proyectos.",
        "El software {request.Nombre} es una plataforma de comercio electr�nico."
        };

    var random = new Random();
    var resultado = resultados[random.Next(resultados.Length)];

    return new
    {
        software = request.NombreSoftware,
        resultado,
        fecha = DateTime.Now
    };
});

app.Run();
public record SoftwareRequest(string NombreSoftware, string Descripcion);
