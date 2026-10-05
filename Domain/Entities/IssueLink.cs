using JiraClone.Domain.Enums;
using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities
{
    public class IssueLink : AuditableEntityBase
    {
        public int Id { get; private set; }

        public int SourceIssueId { get; private set; }

        public int TargetIssueId { get; private set; }

        public IssueLinkType LinkType { get; private set; }


        public IssueLink(
        int sourceIssueId,
        int targetIssueId,
        IssueLinkType linkType,
        int createdBy)
           : base (createdBy)
        {
            SourceIssueId = sourceIssueId;
            TargetIssueId = targetIssueId;
            LinkType = linkType;
        }
    }
}
