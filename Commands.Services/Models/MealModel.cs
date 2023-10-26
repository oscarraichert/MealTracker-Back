using Commands.Infra.Entities.Result;
using Commands.Infra.Models;
using MongoDB.Bson;
using Result.Entities;

namespace Commands.API.Model
{
    public class MealModel
    {
        public required string Name { get; set; }

        public required double Quantity { get; set; }

        public required double Calories { get; set; }

        public required double Proteins { get; set; }

        public required double Carbohydrates { get; set; }

        public required double Fats { get; set; }

        public string? Notes { get; set; }

        public Result<Meal> ToEntity(string id = "")
        {
            ObjectId mealId;

            if (id.Length > 0)
            {
                try
                {
                    mealId = ObjectId.Parse(id);
                }
                catch (Exception)
                {
                    return Result<Meal>.Error(new ValidationError("Invalid ID!!"));
                }
            }

            else
            {
                mealId = ObjectId.GenerateNewId();
            }

            var meal = new Meal
            {
                Id = mealId,
                Name = Name,
                Quantity = Quantity,
                Calories = Calories,
                Proteins = Proteins,
                Carbohydrates = Carbohydrates,
                Fats = Fats,
                CreationDate = DateTime.Now,
                Notes = Notes ?? ""
            };

            return Result<Meal>.Success(meal);
        }
    }
}
