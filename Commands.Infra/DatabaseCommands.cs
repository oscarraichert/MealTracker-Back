using Commands.Infra.Entities.Result;
using Commands.Infra.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Result.Entities;

namespace Commands.Infra
{
    public class DatabaseCommands
    {
        private readonly IMongoCollection<Meal> MealCollection;

        public DatabaseCommands(IOptions<DatabaseSettings> dbSettings)
        {
            var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);

            var database = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);

            MealCollection = database.GetCollection<Meal>(dbSettings.Value.CollectionName);
        }

        public async Task InsertAsync(Meal meal)
        {
            await MealCollection.InsertOneAsync(meal);
        }
    }
}
