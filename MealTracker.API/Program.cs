using MealTracker.Application;
using MealTracker.Infra;
using MealTracker.API.WebAppExtensions;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Net;
using dotenv.net;

namespace MealTracker.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();
            builder.Services.ConfigureDependencyInjection();
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationAssembly).Assembly));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

            DotEnv.Load();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapEndpoints();

            app.Run();
        }        
    }
}