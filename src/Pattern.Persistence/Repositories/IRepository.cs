﻿namespace Pattern.Persistence.Repositories
{
    public interface IRepository<TEntity, TPrimaryKey> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(TPrimaryKey Id);
        Task<TEntity> CreateAsync(TEntity Entity);
        TEntity Update(TEntity Entity);
        TEntity SetValuesAndUpdate(TEntity EntityFromDb, TEntity EntityFromDto);
		void Delete(TEntity Entity);
        void HardDelete(TEntity Entity);
    }
}
