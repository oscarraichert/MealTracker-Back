#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MealTracker.API/MealTracker.API.csproj", "MealTracker.API/"]
COPY ["MealTracker.Application/MealTracker.Application.csproj", "MealTracker.Application/"]
COPY ["MealTracker.Infra/MealTracker.Infra.csproj", "MealTracker.Infra/"]
COPY ["Result.Entities/Result.Entities.csproj", "Result.Entities/"]
RUN dotnet restore "MealTracker.API/MealTracker.API.csproj"
COPY . .
WORKDIR "/src/MealTracker.API"
RUN dotnet build "MealTracker.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MealTracker.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MealTracker.API.dll"]