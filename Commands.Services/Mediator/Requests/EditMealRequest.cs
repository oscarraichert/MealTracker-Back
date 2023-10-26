using Commands.API.Model;
using Commands.Infra.Entities.Result;
using Commands.Infra.Models;
using MediatR;
using Result.Entities;

namespace Commands.Application.Mediator.Requests
{
    public class EditMealRequest : IRequest<Result<Empty>>
    {
        public required string MealId { get; set; }

        public required MealModel Meal { get; set; }
    }
}
