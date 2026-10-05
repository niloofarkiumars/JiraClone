using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class TeamMember : AuditableEntityBase
{
    public int Id { get; private set; }

    public int TeamId { get; private set; }

    public int UserId { get; private set; }

    public DateTime JoinedDate { get; private set; }

    public DateTime? LeftDate { get; private set; }


    public TeamMember(
        int teamId,
        int userId,
        int createdBy)
        :base (createdBy)
    {
        TeamId = teamId;
        UserId = userId;
    }
}