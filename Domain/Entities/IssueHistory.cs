using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class IssueHistory : AuditableEntityBase
{
    public int Id { get; private set; }

    public int IssueId { get; private set; }

    public int UserId { get; private set; }

    public string FieldName { get; private set; }

    public string OldValue { get; private set; }

    public string NewValue { get; private set; }

    public IssueHistory(
        int issueId,
        int userId,
        string fieldName,
        string oldValue,
        string newValue,
        int createdBy)
        :base (createdBy)
    {
        IssueId = issueId;
        UserId = userId;
        FieldName = fieldName;
        OldValue = oldValue;
        NewValue = newValue;
    }
}