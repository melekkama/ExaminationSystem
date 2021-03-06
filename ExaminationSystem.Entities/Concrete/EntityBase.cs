using ExaminationSystem.Entities.Interfaces;

namespace ExaminationSystem.Entities.Concrete;

public abstract class EntityBase : IEntityBase
{
    public Guid Id { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime? UpdatedTime { get; set; }
    public Guid CreatedUserId { get; set; }
    public Guid? UpdatedUserId { get; set; }
    public bool IsDeleted { get; set; }
}

