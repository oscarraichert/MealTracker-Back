#Build
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build
WORKDIR /source
COPY . .
RUN dotnet restore
RUN dotnet publish -c release -o app 

#Serve
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /source
COPY --from=build /source/app .

EXPOSE 5000

ENTRYPOINT ["dotnet", "MealTracker.API.dll"]