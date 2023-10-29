using MealTracker.Infra;
using Result.Entities.Result;
using MealTracker.API.Requests;
using MediatR;
using Result.Entities;

namespace MealTracker.API.Handlers
{
    public class InsertMealHandler : IRequestHandler<InsertMealRequest, Result<Empty>>
    {
        private DatabaseCommands DatabaseCommands;

        public InsertMealHandler(DatabaseCommands dbCommands)
        {
            DatabaseCommands = dbCommands;
        }

        public async Task<Result<Empty>> Handle(InsertMealRequest request, CancellationToken cancellationToken)
        {
            var result = request.Meal.ToEntity();

            if (result.HasFailed())
            {
                return Result<Empty>.Error(result.ErrorData!);
            }

            var meal = result.Data!;

            var correct = meal.CorrectMacros();

            if (correct)
            {
                await DatabaseCommands.InsertAsync(meal);
                return Empty.Value;
            }

            return Result<Empty>.Error(new ValidationError("Error validating calories to macros ratio!"));
        }
    }
}
