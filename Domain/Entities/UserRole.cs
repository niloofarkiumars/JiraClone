using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class UserRole : AuditableEntityBase
{
    public int Id { get; private set; }

    public int UserId { get; private set; }

    public int RoleId { get; private set; }

    public DateTime AssignedDate { get; private set; }

    public DateTime? RemovedDate { get; private set; }


    public UserRole(
      int userId,
      int roleId,
      int createdBy)
        :base (createdBy)
    {
        UserId = userId;
        RoleId = roleId;
    }
}