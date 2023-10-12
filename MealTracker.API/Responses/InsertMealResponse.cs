using MealTracker.API.Dtos;
using MealTracker.API.Requests;

namespace MealTracker.API.Responses
{
    public class InsertMealResponse : InsertMealDto
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }

        public InsertMealResponse(InsertMealRequest request)
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
            MapDto(request);
        }

        private void MapDto(InsertMealRequest request)
        {
            var baseProps =  typeof(InsertMealDto).GetProperties();

            foreach (var prop in baseProps)
            {
                GetType()?.GetProperty(prop.Name)?.SetValue(this, request.GetType()?.GetProperty(prop.Name)?.GetValue(request));
            }
        }
    }
}
