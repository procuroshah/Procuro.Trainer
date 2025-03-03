using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.ApiService.Common
{
    public abstract class BaseEntity : BaseEntity<Guid>
    {
        protected BaseEntity() => Id = Guid.NewGuid();
    }

    public abstract class BaseEntityString : IEntity<string>
    {
        [MaxLength(100)]
        public string? Id { get; set; }
    }
    public abstract class BaseEntity<TId> : IEntity<TId>
    {
        public TId Id { get; protected set; } = default!;

    }

}