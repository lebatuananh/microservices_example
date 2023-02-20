FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/services/Hangfire.api/Hangfire.api.csproj", "src/services/Hangfire.api/"]
RUN dotnet restore "src/services/Hangfire.api/Hangfire.api.csproj"
COPY . .
WORKDIR "/src/src/services/Hangfire.api"
RUN dotnet build "Hangfire.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hangfire.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hangfire.api.dll"]
