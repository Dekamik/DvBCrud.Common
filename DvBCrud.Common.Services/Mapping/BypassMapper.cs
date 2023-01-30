namespace DvBCrud.Common.Services.Mapping;

/// <inheritdoc cref="IBypassMapper{TDataModel}"/>
public abstract class BypassMapper<TEntity> : IBypassMapper<TEntity>
    where TEntity : class
{
    public TEntity ToModel(TEntity dataModel) => dataModel;

    public TEntity ToEntity(TEntity apiModel) => apiModel;
}