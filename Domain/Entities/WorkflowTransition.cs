using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class WorkflowTransition : AuditableEntityBase
{
    public int Id { get; private set; }

    public int WorkflowId { get; private set; }

    public int FromStatusId { get; private set; }

    public int ToStatusId { get; private set; }

    public string Name { get; private set; }

    public bool IsActive { get; private set; }


    public WorkflowTransition(
    int workflowId,
    int fromStatusId,
    int toStatusId,
    string name,
    bool isActive,
    int createdBy)
        :base (createdBy)
    {
        WorkflowId = workflowId;
        FromStatusId = fromStatusId;
        ToStatusId = toStatusId;
        Name = name;
        IsActive = isActive;
    }
}