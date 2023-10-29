using Result.Entities.Result;
using MongoDB.Bson;

namespace MealTracker.Infra.Models
{
    public class Meal
    {
        public required ObjectId Id { get; set; }

        public required DateTime CreationDate { get; set; }

        public required string Name { get; set; }

        public required double Quantity { get; set; }

        public required double Calories { get; set; }

        public required double Proteins { get; set; }

        public required double Carbohydrates { get; set; }

        public required double Fats { get; set; }

        public string? Notes { get; set; }

        public bool CorrectMacros()
        {
            var macrosCal = Proteins * 4 + Carbohydrates * 4 + Fats * 9;

            if (macrosCal > Calories)
            {
                return false;
            }

            return true;
        }
    }
}
