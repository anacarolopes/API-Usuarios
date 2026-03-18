using ApiUsuarios.Data;
using ApiUsuarios.Services;
using Microsoft.EntityFrameworkCore;
using ApiUsuarios.Middlewares;
using ApiUsuarios.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("BancoDeUsuarios"));

builder.Services.AddControllers();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();
app.MapControllers();

app.Run();

