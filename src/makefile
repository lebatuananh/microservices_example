run_product_api : publish_product_api run

run:
	docker compose -f docker-compose.yml -f docker-compose.override.yml up -d --remove-orphans 

publish_product_api:
	dotnet publish "services/Product.Api/Product.Api.csproj" -c Release -o "./app/product.api" 