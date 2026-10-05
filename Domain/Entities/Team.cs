using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class Team : AuditableEntityBase
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public int DepartmentId { get; private set; }

    public int SupervisorUserId { get; private set; }

    public bool IsActive { get; private set; }


    public Team(
        string name,
        string description,
        int departmentId,
        int supervisorUserId,
        bool isActive,
        int createdBy)
        :base (createdBy)
    {
        Name = name;
        Description = description;
        DepartmentId = departmentId;
        SupervisorUserId = supervisorUserId;
        IsActive = isActive;
    }
}