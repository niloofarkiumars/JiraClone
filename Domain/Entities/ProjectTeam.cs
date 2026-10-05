using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class ProjectTeam : AuditableEntityBase
{
    public int Id { get; private set; }

    public int ProjectId { get; private set; }

    public int TeamId { get; private set; }

    public DateTime AssignedDate { get; private set; }

    public DateTime? RemovedDate { get; private set; }


    public ProjectTeam(
        int projectId,
        int teamId,
        int createdBy)
        :base (createdBy)
    {
        ProjectId = projectId;
        TeamId = teamId;
    }
}