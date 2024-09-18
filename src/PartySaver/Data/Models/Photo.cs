namespace PartySaver.Data.Models;

public class Photo
{
    public Guid Id { get; set; }
    public DateTime CreatedDate = DateTime.UtcNow;
    public string? Username { get; set; }
    public CdnFile? PhotoFile { get; set; }
    public Guid? PhotoFileId { get; set; }
    public CdnFile? PreviewFile { get; set; }
    public Guid? PreviewFileId { get; set; }
}