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

//Reposit�rio base para todos os CRUD gen�ricos.
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));


//// Configura��es futuras para o PC Builder
builder.Services.AddScoped<IPcBuilderService, PcBuilderService>();

//// Configura��es futuras para CPU
builder.Services.AddScoped<ICpuService, CpuService>();
builder.Services.AddScoped<ICpuRepository, CpuRepository>();

builder.Services.AddScoped<ISocketProcessadorRepository, SocketProcessadorRepository>();



//// Configura��es futuras para GPU
builder.Services.AddScoped<IGpuService, GpuService>();
builder.Services.AddScoped<IGpuRepository, GpuRepository>();

builder.Services.AddScoped<IGabineteService, GabineteService>();
builder.Services.AddScoped<IGabineteRepository, GabineteRepository>();

//// Configura��es futuras para Placa M�e
builder.Services.AddScoped<IPlacaMaeService, PlacaMaeService>();
builder.Services.AddScoped<IPlacaMaeRepository, PlacaMaeRepository>();

builder.Services.AddScoped<ISoftwareService, SoftwareService>();
builder.Services.AddScoped<ISoftwareRepository, SoftwareRepository>();

//// Configura��es futuras para RAM
builder.Services.AddScoped<IRamService, RamService>();
builder.Services.AddScoped<IRamRepository, RamRepository>();

//// Configura��es futuras para Requisitos de Hardware
builder.Services.AddScoped<IRequisitosHardwareService, RequisitosHardwareService>();
//builder.Services.AddScoped<IBaseRepository<RequisitosHardware>, RequisitosHardwareRepository>();

//// Configura��es futuras para SSD
builder.Services.AddScoped<ISsdService, SsdService>();
//builder.Services.AddScoped<IBaseRepository<Ssd>, SsdRepository>();

//// Configura��es futuras para Fonte
builder.Services.AddScoped<IFonteService, FonteService>();
//builder.Services.AddScoped<IBaseRepository<Fonte>, FonteRepository>();

//// Configura��es futuras para Software
builder.Services.AddScoped<ISoftwareService, SoftwareService>();
//builder.Services.AddScoped<IBaseRepository<Software>, SoftwareRepository>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
