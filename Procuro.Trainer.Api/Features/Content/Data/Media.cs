using Procuro.Trainer.Api.Features.Users.Data;

namespace Procuro.Trainer.Api.Features.Content.Data;

public class Media
{
    public Guid Id { get; set; }
    public string FileName { get; set; } = null!;
    public FileTypeEnum FileType { get; set; } // "Video" or "Document"
    public string Url { get; set; }
    public Guid UploadedById { get; set; }
    public User? UploadedBy { get; set; }
    public DateTime CreatedOnUtc { get; set; }
}

public enum FileTypeEnum
{
    Video = 1,
    Document = 2
}