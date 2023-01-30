namespace DvBCrud.Common.Services.Mapping;

/// <summary>
/// Simple implementation to override the conversion logic of <typeparamref name="TEntity"/>.
/// Use this if you intend to expose your data model directly.
///
/// When you decide to implement your own converter, inherit from <see cref="IMapper{TDataModel,TApiModel}"/> instead.
/// </summary>
/// <typeparam name="TEntity">Entity/data model type</typeparam>
public interface IBypassMapper<TEntity> : IMapper<TEntity, TEntity>
    where TEntity : class
{
}