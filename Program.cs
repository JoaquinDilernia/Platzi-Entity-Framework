using projecef;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TareasContext> (p=> p.UseInMemoryDatabase("TareasDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion" , async ([FromServices] TareasContext dbContext) => {
dbContext.Database.EnsureCreated();
return Results.Ok("Base de datos creada" + dbContext.Database.IsInMemory());
} );

app.Run();
