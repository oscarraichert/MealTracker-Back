using Commands.Infra.Models;

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
                CreationDate = DateTime.Now,
                Notes = Notes ?? ""
            };
        }
    }
}
