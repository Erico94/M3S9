using M3S9_jogos.webApi.Infra;
using M3S9_jogos.webApi.Repositores;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<JogoDbContext>();
builder.Services.AddScoped<EstudioRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
