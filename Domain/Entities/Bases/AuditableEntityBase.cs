using JiraClone.Domain.Interfaces;

namespace JiraClone.Domain.Entities.Bases
{
    public abstract class AuditableEntityBase : IAuditableEntity
    {
        public DateTime CreatedDate { get; protected set; }
        public int CreatedBy { get; protected set; }

        public DateTime? ModifiedDate { get; protected set; }
        public int? ModifiedBy { get; protected set; }

        protected AuditableEntityBase(int createdBy)
        {
            CreatedDate = DateTime.UtcNow;
            CreatedBy = createdBy;
        }

        protected void SetModified(int modifiedBy)
        {
            ModifiedDate = DateTime.UtcNow;
            ModifiedBy = modifiedBy;
        }

    }
}
