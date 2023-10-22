using Commands.Infra.Entities.Result;
using MediatR;
using MongoDB.Bson;
using Result.Entities;

namespace Commands.Application.Mediator.Requests
{
    public class DeleteMealRequest : IRequest<Result<Empty>>
    {
        public required string MealId { get; set; }
    }
}
