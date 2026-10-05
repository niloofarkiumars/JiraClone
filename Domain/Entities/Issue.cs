using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class Issue : AuditableEntityBase
{
    public int Id { get; private set; }
    public long IssueNumber { get; private set; }

    public int ProjectId { get; private set; }
    public int IssueTypeId { get; private set; }
    public int? ParentIssueId { get; private set; }

    public string Title { get; private set; }
    public string Description { get; private set; }

    public int PriorityId { get; private set; }
    public int WorkflowStatusId { get; private set; }
    public int ReporterUserId { get; private set; }

    public int? AssignedTeamId { get; private set; }
    public int? AssignedUserId { get; private set; }

    public int? OriginalEstimateMinutes { get; private set; }
    public int? RemainingEstimateMinutes { get; private set; }

    public bool IsActive { get; private set; }


    public Issue(
        int projectId,
        int issueTypeId,
        string title,
        string description,
        int priorityId,
        int workflowStatusId,
        int reporterUserId,
        long issueNumber,
        int? originalEstimateMinutes,
        int? remainingEstimateMinutes,
        int createdBy)
        : base(createdBy)
    {
        ProjectId = projectId;
        IssueTypeId = issueTypeId;
        Title = title;
        Description = description;
        PriorityId = priorityId;
        WorkflowStatusId = workflowStatusId;
        ReporterUserId = reporterUserId;
        IssueNumber = issueNumber;

        OriginalEstimateMinutes = originalEstimateMinutes;
        RemainingEstimateMinutes = remainingEstimateMinutes;

        IsActive = true;
    }

    public void AssignToTeam(int teamId, int modifiedBy)
    {
        AssignedTeamId = teamId;
        SetModified(modifiedBy);
    }

    public void AssignToUser(int userId, int modifiedBy)
    {
        AssignedUserId = userId;
        SetModified(modifiedBy);
    }

    public void ChangePriority(int priorityId, int modifiedBy)
    {
        PriorityId = priorityId;
        SetModified(modifiedBy);
    }

    public void ChangeStatus(int statusId, int modifiedBy)
    {
        WorkflowStatusId = statusId;
        SetModified(modifiedBy);
    }
}