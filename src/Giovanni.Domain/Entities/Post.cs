using Giovanni.Domain.Common;

namespace Giovanni.Domain.Entities;

public class Post : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public string? Excerpt { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }
}