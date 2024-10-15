using Library.Api;
using Library.Api.Entities;
using Library.Api.Services;
using Library.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<LibraryDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryConnectionString")));

builder.Services.AddScoped<LibrarySeeder>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IPublishingHouseService, PublishingHouseService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<LibrarySeeder>();
seeder.Seed();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();