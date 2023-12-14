using Microsoft.EntityFrameworkCore;
using WebAPI1_Uni;
using WebAPI1_Uni.Domain;
using WebAPI1_Uni.Interfaces;
using WebAPI1_Uni.Services;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

///appsettings.json-da qeyd olunan connection stringden connection ucun istifade olunur (WorldDbContext klassina baxin)
builder.Services.AddDbContext<WorldDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("connection")));


//Dependency Injection
builder.Services.AddScoped<ICity,CityService>();
builder.Services.AddAutoMapper(typeof(Map));





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
