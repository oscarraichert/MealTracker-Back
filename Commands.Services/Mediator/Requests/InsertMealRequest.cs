using Commands.API.Model;
using Commands.Infra.Entities.Result;
using MediatR;

namespace MealTracker.API.Requests
{
    public class InsertMealRequest: IRequest<Result>
    {
        public required MealModel Meal { get; set; }
    }
}
