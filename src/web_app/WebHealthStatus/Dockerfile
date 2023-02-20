FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/web_app/WebHealthStatus/WebHealthStatus.csproj", "src/web_app/WebHealthStatus/"]
RUN dotnet restore "src/web_app/WebHealthStatus/WebHealthStatus.csproj"
COPY . .
WORKDIR "/src/src/web_app/WebHealthStatus"
RUN dotnet build "WebHealthStatus.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebHealthStatus.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebHealthStatus.dll"]
