using Result.Entities.Result;
using MediatR;
using Result.Entities;
using MealTracker.Application.Mediator.Requests;
using MealTracker.Infra;

namespace MealTracker.Application.Mediator.Handlers
{
    public class DeleteMealHandler : IRequestHandler<DeleteMealRequest, Result<Empty>>
    {
        private DatabaseCommands DatabaseCommands;

        public DeleteMealHandler(DatabaseCommands dbCommands)
        {
            DatabaseCommands = dbCommands;
        }

        public async Task<Result<Empty>> Handle(DeleteMealRequest request, CancellationToken cancellationToken)
        {
            var result = await DatabaseCommands.DeleteAsync(request.MealId);

            return result;
        }
    }
}
