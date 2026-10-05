using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class Attachment : AuditableEntityBase
{
    public int Id { get; private set; }

    public int ProjectId { get; private set; }

    public int? IssueId { get; private set; }

    public string FileName { get; private set; }

    public string FileExtension { get; private set; }

    public long FileSize { get; private set; }

    public string StoragePath { get; private set; }

    public string ContentType { get; private set; }

    public Attachment(
        int projectId,
        int? issueId,
        string fileName,
        string fileExtension,
        long fileSize,
        string storagePath,
        string contentType,
        int createdBy)
        : base(createdBy)
    {
        ProjectId = projectId;
        IssueId = issueId;
        FileName = fileName;
        FileExtension = fileExtension;
        FileSize = fileSize;
        StoragePath = storagePath;
        ContentType = contentType;
    }
}