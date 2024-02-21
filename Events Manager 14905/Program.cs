using Events_Manager_14905;
using Events_Manager_14905.Data;
using Events_Manager_14905.Interfaces;
using Events_Manager_14905.Models;
using Events_Manager_14905.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddTransient<Seed>();
builder.Services.AddScoped<IEventRepository, EventRepository>() ;
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Seed the database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var seedService = services.GetRequiredService<Seed>();
        seedService.SeedDataContext();
    }
    catch (Exception ex)
    {
        // Handle any exceptions here
        Console.WriteLine("An error occurred while seeding the database: " + ex.Message);
    }
}

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
