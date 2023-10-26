using Commands.Application.Mediator.Requests;
using Commands.Infra;
using Commands.Infra.Entities.Result;
using MediatR;
using Result.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Application.Mediator.Handlers
{
    public class EditMealHandler : IRequestHandler<EditMealRequest, Result<Empty>>
    {
        private DatabaseCommands DatabaseCommands;

        public EditMealHandler(DatabaseCommands databaseCommands)
        {
            DatabaseCommands = databaseCommands;
        }

        public async Task<Result<Empty>> Handle(EditMealRequest request, CancellationToken cancellationToken)
        {
            var result = request.Meal.ToEntity(request.MealId);

            if (result.HasFailed())
            {
                return Result<Empty>.Error(result.ErrorData!);
            }

            var meal = result.Data!;

            var correct = meal.CorrectMacros();

            if (correct)
            {
                await DatabaseCommands.EditAsync(meal);
                return Empty.Value;
            }

            return Result<Empty>.Error(new ValidationError("Error validating calories to macros ratio!"));
        }
    }
}
