namespace LearningManagementSystem.ApiService.Common
{
    public interface IEntity
    {
    }
    public interface IEntity<out TId> : IEntity
    {
        TId Id { get; }
    }
}