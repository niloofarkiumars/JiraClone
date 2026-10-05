using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class User : AuditableEntityBase
{
    public int Id { get; private set; }

    public int PersonnelId { get; private set; }

    public string PersonnelCode { get; private set; }

    public string Username { get; private set; }

    public string PasswordHash { get; private set; }

    public bool IsActive { get; private set; }

    public User(
        int personnelId,
        string personnelCode,
        string username,
        string passwordHash,
        bool isActive,
        int createdBy)
        :base (createdBy)
    {
        PersonnelId = personnelId;
        PersonnelCode = personnelCode;
        Username = username;
        PasswordHash = passwordHash;
        IsActive = isActive;
    }
}