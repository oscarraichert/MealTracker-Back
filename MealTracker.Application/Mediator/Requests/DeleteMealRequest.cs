using Result.Entities.Result;
using MediatR;
using Result.Entities;

namespace MealTracker.Application.Mediator.Requests
{
    public class DeleteMealRequest : IRequest<Result<Empty>>
    {
        public required string MealId { get; set; }
    }
}
