using Commands.Infra;
using Commands.Infra.Models;
using MealTracker.API.Requests;
using System.Security.Cryptography.X509Certificates;

namespace Commands.Services
{
    public class Services
    {
        private DatabaseCommands databaseCommands;

        public Services(DatabaseCommands dbCommands)
        {
            databaseCommands = dbCommands;
        }

        public async Task InsertAsync(InsertMealRequest mealRequest)
        {
            var meal = mealRequest.ToEntity();

            await databaseCommands.InsertAsync(meal);
        }
    }
}