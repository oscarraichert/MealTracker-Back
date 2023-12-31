﻿using Result.Entities.Result;
using MealTracker.Infra.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using Result.Entities;

namespace MealTracker.Infra
{
    public class DatabaseCommands
    {
        private readonly IMongoCollection<Meal> MealCollection;

        public DatabaseCommands(IOptions<DatabaseSettings> dbSettings)
        {
            var mongoClient = new MongoClient(Environment.GetEnvironmentVariable("connectionString"));

            var database = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);

            MealCollection = database.GetCollection<Meal>(dbSettings.Value.CollectionName);
        }

        public async Task InsertAsync(Meal meal)
        {
            await MealCollection.InsertOneAsync(meal);
        }

        public async Task<Result<Empty>> DeleteAsync(string id)
        {
            try
            {
                await MealCollection.DeleteOneAsync(x => x.Id == ObjectId.Parse(id));
                return Empty.Value;
            }
            catch (Exception)
            {
                return Result<Empty>.Error(new ValidationError("Invalid object ID!"));
            }
        }

        public async Task<Result<Empty>> EditAsync(Meal meal)
        {
            try
            {
                await MealCollection.FindOneAndReplaceAsync(x => x.Id == meal.Id, meal);
                return Empty.Value;

            }
            catch (Exception)
            {
                return Result<Empty>.Error(new ValidationError("Invalid object ID!"));
            }
        }
    }
}
