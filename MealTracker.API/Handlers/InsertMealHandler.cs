using MealTracker.API.Requests;
using MealTracker.API.Responses;
using MediatR;

namespace MealTracker.API.Handlers
{
    public class InsertMealHandler : IRequestHandler<InsertMealRequest, InsertMealResponse>
    {
        public async Task<InsertMealResponse> Handle(InsertMealRequest request, CancellationToken cancellationToken)
        {
            var response = new InsertMealResponse(request);

            return await Task.FromResult(response);
        }
    }
}
