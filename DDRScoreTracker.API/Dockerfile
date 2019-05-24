FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["DDRScoreTracker.API/DDRScoreTracker.API.csproj", "DDRScoreTracker.API/"]
RUN dotnet restore "DDRScoreTracker.API/DDRScoreTracker.API.csproj"
COPY . .
WORKDIR "/src/DDRScoreTracker.API"
RUN dotnet build "DDRScoreTracker.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DDRScoreTracker.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DDRScoreTracker.API.dll"]
