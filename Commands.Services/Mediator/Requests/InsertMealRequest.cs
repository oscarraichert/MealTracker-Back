using Commands.API.Model;
using MediatR;

namespace MealTracker.API.Requests
{
    public class InsertMealRequest: IRequest<string>
    {
        public required MealModel Meal { get; set; }
    }
}
