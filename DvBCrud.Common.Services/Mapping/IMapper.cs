namespace DvBCrud.Common.Services.Mapping;

/// <summary>
/// Base class for implementing conversion logic between <typeparamref name="TEntity"/> and <typeparamref name="TModel"/>.
/// </summary>
/// <typeparam name="TEntity">Entity/data model type</typeparam>
/// <typeparam name="TModel">API model type</typeparam>
public interface IMapper<TEntity, TModel>
{
    TModel ToModel(TEntity dataModel);
    TEntity ToEntity(TModel apiModel);
}