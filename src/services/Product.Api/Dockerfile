FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/services/Product.Api/Product.Api.csproj", "src/services/Product.Api/"]
RUN dotnet restore "src/services/Product.Api/Product.Api.csproj"
COPY . .
WORKDIR "/src/src/services/Product.Api"
RUN dotnet build "Product.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Product.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Product.Api.dll"]
