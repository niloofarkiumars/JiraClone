using JiraClone.Domain.Enums;

namespace JiraClone.Domain.Entities
{
    public class WorkLog
    {
        public int Id { get; private set; }

        public int IssueId { get; private set; }

        public int UserId { get; private set; }

        public WorkType WorkType { get; private set; }

        public int TimeSpentMinutes { get; private set; }

        public DateTime StartedAt { get; private set; }

        public string? Description { get; private set; }

        public WorkLog(
            int issueId,
            int userId,
            WorkType workType,
            int timeSpentMinutes,
            DateTime startedAt,
            string? description)
        {
            IssueId = issueId;
            UserId = userId;
            WorkType = workType;
            TimeSpentMinutes = timeSpentMinutes;
            StartedAt = startedAt;
            Description = description;
        }
    }
}