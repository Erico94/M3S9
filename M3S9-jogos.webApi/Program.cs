using M3S9_jogos.webApi.Infra;
using M3S9_jogos.webApi.Repositores;
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using M3S9_jogos.webApi.DTOs.Estudios;
using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.DTOs.Jogos;
using M3S9_jogos.webApi.Services.Jogo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var variavelAmbiente = builder.Environment.EnvironmentName;
var diretorio = Directory.GetCurrentDirectory();

builder.Configuration
       .SetBasePath(diretorio)
       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
       .AddJsonFile($"appsettings.{variavelAmbiente}.json", optional: false, reloadOnChange: true);
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;


builder.Services
       .AddDbContext<JogoDbContext>(options =>
                                             options.UseSqlServer(connectionString));
//builder.Services.AddDbContext<JogoDbContext>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


builder.Services.AddScoped<IEstudioServices, EstudioServices>();
builder.Services.AddScoped<IJogosService, JogosService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Jogos", Description = "API CRUD JOGOS", Version = "v1" });
});

builder.Services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();//config mapper
var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<Estudio, EstudioViewDTO>();
    cfg.CreateMap<Jogo, ViewJogoDTO>();

    cfg.CreateMap<CreateEstudioDTO, Estudio>();
    cfg.CreateMap<CreateJogoDTO, Jogo>();

    cfg.CreateMap<UpdateEstudioDTO, Estudio>();
    cfg.CreateMap<UpdateJogoDTO, Jogo>();
});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API JOGOS");
});

//Cors
app.UseCors(p =>
{
    p.AllowAnyOrigin();
    p.AllowAnyHeader();
    p.AllowAnyMethod();
});

app.UseAuthorization();

app.MapControllers();

app.Run();


