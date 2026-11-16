using Giovanni.Domain.Common;

namespace Giovanni.Domain.Entities;

public class Media : BaseEntity
{
    public string FileName { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;

    public string MimeType { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
        = DateTime.UtcNow;
}