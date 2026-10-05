using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class Project : AuditableEntityBase
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    public string Key { get; private set; }

    public string Description { get; private set; }

    public int ProjectManagerUserId { get; private set; }

    public bool IsActive { get; private set; }


    public Project(
        string name,
        string key,
        string description,
        int projectManagerUserId,
        bool isActive,
        int createdBy)
        :base (createdBy)
    {
        Name = name;
        Key = key;
        Description = description;
        ProjectManagerUserId = projectManagerUserId;
        IsActive = isActive;
    }
}