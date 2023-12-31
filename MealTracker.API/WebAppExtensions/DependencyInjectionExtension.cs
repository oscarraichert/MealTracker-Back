﻿using MealTracker.Infra;
using System.Runtime.CompilerServices;

namespace MealTracker.API.WebAppExtensions
{
    public static class DependencyInjectionExtension
    {
        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddSingleton<DatabaseSettings>();
            services.AddTransient<DatabaseCommands>();
        }
    }
}
