using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class RolePermission : AuditableEntityBase
{
    public int Id { get; private set; }

    public int RoleId { get; private set; }
    public int PermissionId { get; private set; }


    public RolePermission(
        int roleId,
        int permissionId,
        int createdBy)
        :base(createdBy)
    {
        RoleId = roleId;
        PermissionId = permissionId;
    }
}