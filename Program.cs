var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.MapGet("/", () =>
{
    return "Hola Mundo";
});

app.MapGet("/saludo", () =>
{
    return "Hola desde la ruta "/;
});

app.MapGet ("/aneudi_clemente", () =>
{
    return new  {
        nombre = "aneudi Elias",
        apellido = "clemente vasquez",
        edad = 30,
        matricula = "Lr-2024-01655",    
        carrera = "Ingenieria de software"
    };
});


app.Run();

