using Giovanni.Domain.Common;

namespace Giovanni.Domain.Entities;

public class MenuItem : BaseEntity
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal Price { get; set; }
    
    public string? PriceDescription { get; set; }
    
    public decimal Rating { get; set; }

    public string? ImagePath { get; set; }

    public int SortOrder { get; set; }

    public Category Category { get; set; } = null!;
}