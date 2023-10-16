using Commands.API.Model;
using Commands.Infra;
using MealTracker.API.Requests;
using MediatR;
using MongoDB.Bson;

namespace MealTracker.API.Handlers
{
    public class InsertMealHandler : IRequestHandler<InsertMealRequest, string>
    {
        private DatabaseCommands databaseCommands;

        public InsertMealHandler(DatabaseCommands dbCommands)
        {
            databaseCommands = dbCommands;
        }

        public async Task<string> Handle(InsertMealRequest request, CancellationToken cancellationToken)
        {
            await databaseCommands.InsertAsync(request.Meal.ToEntity());

            return "Success";
        }
    }
}
