using E_Shop_Catalog.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataBaseContex>(option => option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataBaseContex>(options =>
{
    try
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")); // Подставьте вашу строку подключения
        Console.WriteLine(" connection ready");

    }
    catch {
        Console.WriteLine("NO connection");
    }
});
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
