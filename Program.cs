using API_Filmes_SENAI.Repositories;
using API_Filmes_SENAI.Context;
using API_Filmes_SENAI.Domains;
using API_Filmes_SENAI.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o contexto do banco de dados (exemplo com SQL Server)
builder.Services.AddDbContext<Filmes_Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionar o repositório e a interface ao continuar a injeção de dependência 
builder.Services.AddScoped<IGeneroRepository,GeneroRepository>();
builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();

// Adicionar o serviço de Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Adicionar o Mapeamento dos Controllersl
app.MapControllers();

app.Run();

