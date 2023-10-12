using MealTracker.API.Requests;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MealTracker.API.WebAppExtensions
{
    public static class EndpointExtensions
    {
        public static void MapEndpoints(this WebApplication app)
        {
            app.MapGet("/test", (HttpContext ctx) =>
            {
                return "funfando";
            });

            app.MapPost("/insert", async (IMediator mediatr, InsertMealRequest req) =>
            {
                var response = await mediatr.Send(req);
                return response;
            });
        }
    }
}
