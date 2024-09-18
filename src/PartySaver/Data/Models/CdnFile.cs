using System.ComponentModel.DataAnnotations;

namespace PartySaver.Data.Models;

public class CdnFile
{
    public Guid Id { get; set; }
    public DateTime CreatedDate = DateTime.UtcNow;
    [Required] public string? RelPath { get; set; }
    [Required] public string? FileType { get; set; }
    [Required] public string? OriginalName { get; set; }
}