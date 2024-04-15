using Microsoft.EntityFrameworkCore;
using SimuladorPC.Data;
using SimuladorPC.Data.Repositories;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Application.Services;

using SimuladorPC.Domain.Interfaces.Repositories;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
builder.Services.AddDbContext<SimuladorPcContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SimuladorPcDatabase")));

builder.Services.AddScoped<IGabineteService, GabineteService>();
builder.Services.AddScoped<IGabineteRepository, GabineteRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
