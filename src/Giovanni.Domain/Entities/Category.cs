using Giovanni.Domain.Common;
using Giovanni.Domain.Enums;

namespace Giovanni.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;
    
    public string MetaTitle { get; set; } = string.Empty;
    
    public string MetaDescription { get; set; } = string.Empty;

    public CategoryType CategoryType { get; set; } = CategoryType.Post;

    public int SortOrder { get; set; }

    public bool IsActive { get; set; } = true;

    public ICollection<MenuItem> MenuItems { get; set; }
        = new List<MenuItem>();
}