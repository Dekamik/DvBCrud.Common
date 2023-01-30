﻿namespace DvBCrud.Common.Services.Mapping;

/// <summary>
/// Simple implementation to override the conversion logic of <typeparamref name="TEntity"/>.
/// Use this if you intend to expose your data model directly.
///
/// When you decide to implement your own converter, inherit from <see cref="IMapper{TEntity,TModel}"/> instead.
/// </summary>
/// <typeparam name="TEntity">Entity/data model type</typeparam>
public abstract class BypassMapper<TEntity> : IMapper<TEntity, TEntity>
    where TEntity : class
{
    public TEntity ToModel(TEntity entity) => entity;

    public TEntity ToEntity(TEntity entity) => entity;
}