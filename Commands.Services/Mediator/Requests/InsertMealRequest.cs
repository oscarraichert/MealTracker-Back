﻿using Commands.API.Model;
using Commands.Infra.Entities.Result;
using MediatR;
using Result.Entities;

namespace MealTracker.API.Requests
{
    public class InsertMealRequest: IRequest<Result<Empty>>
    {
        public required MealModel Meal { get; set; }
    }
}
