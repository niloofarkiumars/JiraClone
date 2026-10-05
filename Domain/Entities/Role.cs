using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class Role : AuditableEntityBase
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public bool IsActive { get; private set; }

    public Role(
        string name,
        string description,
        bool isActive,
        int createdBy)
        :base (createdBy)
    {
        Name = name;
        Description = description;
        IsActive = isActive;
    }
}