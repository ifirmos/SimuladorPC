using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Interfaces.Repositories;
using System.Text.Json.Serialization;
using SimuladorPC.Infrastructure.Repositories;
using SimuladorPC.Domain.Services;
using SimuladorPC.Infrastructure.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
builder.Services.AddDbContext<SimuladorPcContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SimuladorPcDatabase")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<ICpuRepository, CpuRepository>();
builder.Services.AddScoped<IGpuRepository, GpuRepository>();
builder.Services.AddScoped<IGabineteRepository, GabineteRepository>();
builder.Services.AddScoped<IRequisitosHardwareService, RequisitosHardwareService>();
builder.Services.AddScoped<IRequisitosHardwareRepository, RequisitosHardwareRepository>();
builder.Services.AddScoped<IRamRepository, RamRepository>();
builder.Services.AddScoped<IPlacaMaeRepository, PlacaMaeRepository>();
builder.Services.AddScoped<ISoftwareRepository, SoftwareRepository>();
builder.Services.AddScoped<IWaterCoolerRepository, WaterCoolerRepository>();

builder.Services.AddScoped<ICpuService, CpuService>();
builder.Services.AddScoped<IGpuService, GpuService>();
builder.Services.AddScoped<IGabineteService, GabineteService>();
builder.Services.AddScoped<IPlacaMaeService, PlacaMaeService>();
builder.Services.AddScoped<ISoftwareService, SoftwareService>();
builder.Services.AddScoped<IRamService, RamService>();
builder.Services.AddScoped<ISsdService, SsdService>();
builder.Services.AddScoped<IFonteService, FonteService>();
builder.Services.AddScoped<IWaterCoolerService, WaterCoolerService>();
builder.Services.AddScoped<IPcBuilderService, PcBuilderService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(AutoMappingConfig));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
