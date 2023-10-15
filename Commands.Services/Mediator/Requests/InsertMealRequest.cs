using Amazon.Runtime.Internal;
using Commands.Infra.Models;
using MediatR;
using MongoDB.Bson.Serialization.Attributes;

namespace MealTracker.API.Requests
{
    public class InsertMealRequest: IRequest<string>
    {
        private DateTime CreationDate { get; set; }

        public string Name { get; set; }

        public double Quantity { get; set; }

        public double Calories { get; set; }

        public double Proteins { get; set; }

        public double Carbohydrates { get; set; }

        public double Fats { get; set; }

        public string Notes { get; set; }

        public Meal ToEntity()
        {
            var meal = new Meal();

            var baseProps = meal.GetType().GetProperties();

            foreach (var prop in baseProps)
            {
                meal.GetType()?.GetProperty(prop.Name)?.SetValue(meal, GetType()?.GetProperty(prop.Name)?.GetValue(this));
            }

            return meal;
        }
    }
}
