using Commands.Services;
using MealTracker.API.Requests;
using MediatR;
using MongoDB.Bson;

namespace MealTracker.API.Handlers
{
    public class InsertMealHandler : IRequestHandler<InsertMealRequest, string>
    {
        private readonly Services Services;

        public InsertMealHandler(Services services)
        {
            Services = services;
        }

        public async Task<string> Handle(InsertMealRequest request, CancellationToken cancellationToken)
        {
            await Services.InsertAsync(request);

            return await Task.FromResult("Success");
        }
    }
}
