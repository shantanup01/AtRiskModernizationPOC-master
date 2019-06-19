FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Microservices/AtRiskHistory/AtRiskHistory.API/AtRiskHistory.API.csproj", "src/Microservices/AtRiskHistory/AtRiskHistory.API/"]
RUN dotnet restore "src/Microservices/AtRiskHistory/AtRiskHistory.API/AtRiskHistory.API.csproj"
COPY . .
WORKDIR "/src/src/Microservices/AtRiskHistory/AtRiskHistory.API"
RUN dotnet build "AtRiskHistory.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AtRiskHistory.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AtRiskHistory.API.dll"]
