using M3S9_jogos.webApi.Infra;
using M3S9_jogos.webApi.Repositores;
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using M3S9_jogos.webApi.DTOs.Estudios;
using M3S9_jogos.webApi.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<JogoDbContext>();
builder.Services.AddScoped<EstudioRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Jogos", Description = "API CRUD JOGOS", Version = "v1" });
});

var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<Estudio, EstudioViewDTO>();
    cfg.CreateMap<CreateEstudioDTO, Estudio>();
    cfg.CreateMap<UpdateEstudioDTO, Estudio>();
});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API JOGOS");
});
app.UseAuthorization();

app.MapControllers();

app.Run();


