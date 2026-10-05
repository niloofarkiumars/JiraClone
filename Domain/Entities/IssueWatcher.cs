using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class IssueWatcher : AuditableEntityBase
{
    public int Id { get; private set; }

    public int IssueId { get; private set; }

    public int UserId { get; private set; }

    public DateTime WatchedDate { get; private set; }


    public IssueWatcher(
        int issueId,
        int userId,
        int createdBy)
        :base (createdBy)
    {
        IssueId = issueId;
        UserId = userId;
    }
}