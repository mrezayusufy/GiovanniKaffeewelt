using Giovanni.Domain.Common;

namespace Giovanni.Domain.Entities;

public class SectionImage : BaseEntity
{
    public int SectionId { get; set; }

    public string ImagePath { get; set; } = string.Empty;

    public int SortOrder { get; set; }

    public Section Section { get; set; } = null!;
}