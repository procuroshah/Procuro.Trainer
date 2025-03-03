using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.ApiService.Common
{
    public abstract class AuditableEntity : AuditableEntity<Guid> { }
    public abstract class AuditableEntityWithTrail : AuditableEntityWithTrail<Guid>{ }

    /// <summary>
    /// Adds shadow properties for auditing and logs entries to Audit trail
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AuditableEntityWithTrail<T> : AuditableEntity<T>, IAuditableEntityWithTrail { }

    public abstract class AuditableEntity<T> : BaseEntity<T>, IAuditableEntity
    {
        [MaxLength(100)]
        public string? CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;

        [MaxLength(100)]
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOnUtc { get; set; } = DateTime.UtcNow;
    }


    public abstract class AuditableEntityWithSoftDelete<T> : AuditableEntity<T>, ISoftDelete
    {
        public DateTime? DeletedOnUtc { get; set; }
        [MaxLength(50)]
        public string? DeletedBy { get; set; }
    }
    
    public abstract class AuditableEntityString : BaseEntityString, IAuditableEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOnUtc { get; set; }
    }
    public abstract class AuditableEntityStringSoftDelete : BaseEntityString, IAuditableEntity, ISoftDelete
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOnUtc { get; set; }
        public DateTime? DeletedOnUtc { get; set; }
        public string? DeletedBy { get; set; }
    }

}