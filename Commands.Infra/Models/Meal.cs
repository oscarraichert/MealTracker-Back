using MongoDB.Bson.Serialization.Attributes;

namespace Commands.Infra.Models
{
    [BsonIgnoreExtraElements]
    public class Meal
    {
        private DateTime CreationDate { get; set; }

        public string Name { get; set; }

        public double Quantity { get; set; }

        public double Calories { get; set; }

        public double Proteins { get; set; }

        public double Carbohydrates { get; set; }

        public double Fats { get; set; }

        public string Notes { get; set; }

        public Meal()
        {
            CreationDate = DateTime.Now;
        }
    }
}
