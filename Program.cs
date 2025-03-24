using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Sessions_app.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Empresa de Brinquedos API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Brinquedos API v1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


try
{
    Console.WriteLine("Iniciando aplicação...");
    app.Run();
    Console.WriteLine("Aplicação encerrada normalmente");
}
catch (Exception ex)
{
    Console.WriteLine($"Falha catastrófica: {ex}");
}