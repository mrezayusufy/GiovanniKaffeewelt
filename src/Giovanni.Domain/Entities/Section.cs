using Giovanni.Domain.Common;

namespace Giovanni.Domain.Entities;

public class Section : BaseEntity
{
    public string Slug { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string? Content { get; set; }

    public bool IsActive { get; set; } = true;

    public int SortOrder { get; set; }

    public ICollection<SectionImage> Images { get; set; }
        = new List<SectionImage>();
}