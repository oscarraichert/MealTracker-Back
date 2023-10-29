using MealTracker.Application.Mediator.Requests;
using MealTracker.API.Requests;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MealTracker.API.WebAppExtensions
{
    public static class EndpointExtensions
    {
        public static void MapEndpoints(this WebApplication app)
        {
            app.MapGet("/alive", () =>
            {
                return "alive!";
            });

            app.MapPost("/insert", async (IMediator mediator, InsertMealRequest req) =>
            {
                var result = await mediator.Send(req);

                if (result.HasFailed())
                {
                    return Results.BadRequest(result.ErrorData);
                }

                return Results.NoContent();
            });

            app.MapPost("/delete", async (IMediator mediator, DeleteMealRequest req) =>
            {
                var result = await mediator.Send(req);

                if (result.HasFailed())
                {
                    return Results.BadRequest(result.ErrorData);
                }

                return Results.NoContent();
            });

            app.MapPut("/edit", async (IMediator mediator, EditMealRequest req) =>
            {
                var result = await mediator.Send(req);

                if (result.HasFailed())
                {
                    return Results.BadRequest(result.ErrorData);
                }

                return Results.NoContent();
            });
        }
    }
}
