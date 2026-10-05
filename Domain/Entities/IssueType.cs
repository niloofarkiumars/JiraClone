using JiraClone.Domain.Entities.Bases;

namespace JiraClone.Domain.Entities;

public class IssueType : AuditableEntityBase
{
    public int Id { get; private set; }

    public string Name { get; private set; }
    public string Code { get; private set; }

    public string Description { get; private set; }

    public bool IsActive { get; private set; }


    public IssueType
        (string name ,
        string code ,
        string description ,
        bool isActive ,
        int createdBy 
        )
        :base (createdBy)
    {
      Name = name;
      Code = code;
      Description = description;
      IsActive = isActive;
    }
}