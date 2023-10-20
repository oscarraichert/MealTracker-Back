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
                var result = await mediatr.Send(req);

                if (result.HasFailed())
                {
                    return Results.BadRequest(result.ErrorData);
                }

                return Results.NoContent();
            });
        }
    }
}
