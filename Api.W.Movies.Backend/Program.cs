using Api.W.Movies.Backend.DAL;
using Api.W.Movies.Backend.MoviesMappers;
using Api.W.Movies.Backend.Repository;
using Api.W.Movies.Backend.Repository.IRepository;
using Api.W.Movies.Backend.Services;
using Api.W.Movies.Backend.Services.IServices;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));
builder.Services.AddControllers();

builder.Services.AddAutoMapper(x => x.AddProfile<Mappers>());

//Injeccion de servicios
builder.Services.AddScoped<ICategoryService, CategoryServices>();

//Injeccion de repository
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

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