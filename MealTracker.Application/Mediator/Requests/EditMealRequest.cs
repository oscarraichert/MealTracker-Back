using MealTracker.API.Model;
using Result.Entities.Result;
using MealTracker.Infra.Models;
using MediatR;
using Result.Entities;

namespace MealTracker.Application.Mediator.Requests
{
    public class EditMealRequest : IRequest<Result<Empty>>
    {
        public required string MealId { get; set; }

        public required MealModel Meal { get; set; }
    }
}
