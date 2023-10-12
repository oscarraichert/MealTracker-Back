namespace MealTracker.API.Dtos
{
    public abstract class InsertMealDto
    {
        public string Name { get; set; }

        public double Quantity { get; set; }

        public double Calories { get; set; }

        public double Proteins { get; set; }

        public double Carbohydrates { get; set; }

        public double Fats { get; set; }

        public string Notes { get; set; }
    }
}
