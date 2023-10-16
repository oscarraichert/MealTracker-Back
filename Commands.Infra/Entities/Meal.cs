namespace Commands.Infra.Models
{
    public class Meal
    {
        public required DateTime CreationDate { get; set; }

        public required string Name { get; set; }

        public required double Quantity { get; set; }

        public required double Calories { get; set; }

        public required double Proteins { get; set; }

        public required double Carbohydrates { get; set; }

        public required double Fats { get; set; }

        public string? Notes { get; set; }
    }
}
