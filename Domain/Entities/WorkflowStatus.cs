using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class WorkflowStatus : AuditableEntityBase
{
    public int Id { get; private set; }

    public int WorkflowId { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public bool IsInitial { get; private set; }

    public bool IsFinal { get; private set; }

    public bool IsActive { get; private set; }


    public WorkflowStatus(
    int workflowId,
    string name,
    string description,
    bool isInitial,
    bool isFinal,
    bool isActive,
    int createdBy)
        :base(createdBy)
    {
        WorkflowId = workflowId;
        Name = name;
        Description = description;
        IsInitial = isInitial;
        IsFinal = isFinal;
        IsActive = isActive;
    }
}