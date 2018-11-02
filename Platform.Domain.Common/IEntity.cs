namespace Platform.Domain.Common
{
    public interface IEntity<in TEntity> : IEntity
    {
        bool IsPersisted();
    }

    public interface IEntity : IAudit
    {

    }
}