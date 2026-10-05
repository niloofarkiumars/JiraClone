using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class Comment : AuditableEntityBase
{
    public int Id { get; private set; }

    public int IssueId { get; private set; }

    public int UserId { get; private set; }

    public string Text { get; private set; }


    public Comment(
       int issueId,
       int userId,
       string text,
       int createdBy)
        : base(createdBy)
    {
        IssueId = issueId;
        UserId = userId;
        Text = text;
    }
}