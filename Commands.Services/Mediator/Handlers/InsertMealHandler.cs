using Commands.Infra;
using Commands.Infra.Entities.Result;
using MealTracker.API.Requests;
using MediatR;
using Result.Entities;

namespace MealTracker.API.Handlers
{
    public class InsertMealHandler : IRequestHandler<InsertMealRequest, Result<Empty>>
    {
        private DatabaseCommands databaseCommands;

        public InsertMealHandler(DatabaseCommands dbCommands)
        {
            databaseCommands = dbCommands;
        }

        public async Task<Result<Empty>> Handle(InsertMealRequest request, CancellationToken cancellationToken)
        {
            var meal = request.Meal.ToEntity();
            var correct = meal.CorrectMacros();

            if (correct)
            {
                await databaseCommands.InsertAsync(meal);
                return Empty.Value;
            }

            return Result<Empty>.Error(new ValidationError("Error validating calories to macros ratio!"));
        }
    }
}
