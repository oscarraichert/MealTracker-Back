namespace MealTracker.API.Dtos
{
    public class InsertMealDto
    {
        public string Name { get; set; }

        public double Quantity { get; set; }

        public double Calories { get; set; }

        public double Proteins { get; set; }

        public double Carbohydrates { get; set; }

        public double Fats { get; set; }

        public string Notes { get; set; }

        public InsertMealDto(string name, double calories, double proteins, double carbohydrates, double fats, string notes)
        {
            Name = name;
            Calories = calories;
            Proteins = proteins;
            Carbohydrates = carbohydrates;
            Fats = fats;
            Notes = notes;
        }
    }
}
