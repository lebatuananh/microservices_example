using System.ComponentModel.DataAnnotations;

namespace Shared.Dto.Products;

public class CreateProductDto: CreateOrUpdateProductDto
{
    [Required]
    public string No { get; set; }
}