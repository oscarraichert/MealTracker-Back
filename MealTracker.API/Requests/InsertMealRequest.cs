using MealTracker.API.Dtos;
using MealTracker.API.Responses;
using MediatR;

namespace MealTracker.API.Requests
{
    public class InsertMealRequest: InsertMealDto, IRequest<InsertMealResponse>
    {
    }
}
