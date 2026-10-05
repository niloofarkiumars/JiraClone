namespace JiraClone.Domain.Interfaces;

public interface IAuditableEntity
{
    DateTime CreatedDate { get; }
    int CreatedBy { get; }

    DateTime? ModifiedDate { get; }
    int? ModifiedBy { get; }
}