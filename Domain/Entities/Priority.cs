using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class Priority : AuditableEntityBase
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public int SortOrder { get; private set; }

    public bool IsActive { get; private set; }


    public Priority(
        string name,
        string description,
        int sortOrder,
        bool isActive,
        int createdBy)
        :base (createdBy)
    {
        Name = name;
        Description = description;
        SortOrder = sortOrder;
        IsActive = isActive;
    }
}