using ApiUsuarios.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("BancoDeUsuarios"));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

