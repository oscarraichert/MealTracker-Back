using MealTracker.API.Dtos;

namespace MealTracker.API.WebAppExtensions
{
    public static class EndpointExtensions
    {
        public static void MapEndpoints(this WebApplication app)
        {
            app.MapGet("/index", (HttpContext ctx) =>
            {
                ctx.Response.ContentType = "text/html";

                return File.ReadAllText("index.html");
            });

            app.MapGet("/test", (HttpContext ctx) =>
            {
                return "funfando";
            });

            app.MapPost("/insert", (InsertMealDto newMeal) =>
            {
                Console.WriteLine($"New meal is : {newMeal.Name}." +
                    $"\nIt has {newMeal.Calories} Kcal, {newMeal.Proteins} Proteins and {newMeal.Fats} Fats.");
            });
        }
    }
}
