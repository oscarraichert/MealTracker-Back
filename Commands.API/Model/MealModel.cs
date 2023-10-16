using Commands.Infra.Models;

namespace Commands.API.Model
{
    public class MealModel
    {
        public required string Name { get; set; }

        public double Quantity { get; set; }

        public double Calories { get; set; }

        public double Proteins { get; set; }

        public double Carbohydrates { get; set; }

        public double Fats { get; set; }

        public required string Notes { get; set; }

        public Meal ToEntity()
        {
            return new Meal
            {
                Name = Name,
                Quantity = Quantity,
                Calories = Calories,
                Proteins = Proteins,
                Carbohydrates = Carbohydrates,
                Fats = Fats,
                CreationDate = DateTime.Now
            };
        }
    }
}
