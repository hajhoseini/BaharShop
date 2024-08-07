using BaharShop.Application;
using BaharShop.InfraStructure;
using BaharShop.InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace BaharShop.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<BaharShopDBContext>(options =>
                        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddControllers();
            builder.Services.InfraStructureServiceCollections();
            builder.Services.ApplicationServiceCollections();

            // Add services to the container.
            builder.Services.AddAuthorization();


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            //    var summaries = new[]
            //    {
            //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            //};

            //    app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            //    {
            //        var forecast = Enumerable.Range(1, 5).Select(index =>
            //       new WeatherForecast
            //            {
            //                Date = DateTime.Now.AddDays(index),
            //                TemperatureC = Random.Shared.Next(-20, 55),
            //                Summary = summaries[Random.Shared.Next(summaries.Length)]
            //            })
            //            .ToArray();
            //        return forecast;
            //    });

            app.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}