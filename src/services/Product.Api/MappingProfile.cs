using AutoMapper;
using Infrastructure.Mappings;
using Product.Api.Entities;
using Shared.Dto.Products;

namespace Product.Api;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CatalogProduct, ProductDto>();
        CreateMap<CreateProductDto, CatalogProduct>();
        CreateMap<UpdateProductDto, CatalogProduct>()
            .IgnoreAllNonExisting();
    }
}