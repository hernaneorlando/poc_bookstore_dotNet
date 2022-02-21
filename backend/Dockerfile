FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY backend/ .
RUN dotnet restore "BookStore.sln"
RUN dotnet publish "Bs.Web/Bs.Web.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Bs.Web.dll"]