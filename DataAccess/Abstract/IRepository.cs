﻿using Core.DataAccess.Abstract;
using Core.Entities.Abstract;

namespace DataAccess.Abstract;

public interface IRepository : IAsyncDisposable
{
    IEntityRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity, new();

    TRepository GetRepository<TEntity, TRepository>()
        where TEntity : class, IEntity, new()
        where TRepository : IEntityRepository<TEntity>;


    Task<int> SaveAsync();
    int Save();
}