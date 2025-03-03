namespace LearningManagementSystem.ApiService.Common
{
    public interface IAuditableEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOnUtc { get; set; }
    }

    public interface IAuditableEntityWithTrail
    {

    }
}