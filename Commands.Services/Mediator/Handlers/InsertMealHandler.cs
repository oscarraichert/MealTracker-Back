using Commands.Infra;
using Commands.Infra.Entities.Result;
using MealTracker.API.Requests;
using MediatR;

namespace MealTracker.API.Handlers
{
    public class InsertMealHandler : IRequestHandler<InsertMealRequest, Result>
    {
        private DatabaseCommands databaseCommands;

        public InsertMealHandler(DatabaseCommands dbCommands)
        {
            databaseCommands = dbCommands;
        }

        public async Task<Result> Handle(InsertMealRequest request, CancellationToken cancellationToken)
        {
            var result = await databaseCommands.InsertAsync(request.Meal.ToEntity());

            if (result.HasFailed())
            {
                throw new Exception(result.ErrorMessage);
            }

            return result;
        }
    }
}
