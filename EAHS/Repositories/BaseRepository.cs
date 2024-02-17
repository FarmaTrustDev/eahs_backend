using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using EAHS.Interfaces;

namespace EAHS.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly EAHSDbContext _cGTContext;

        public BaseRepository(EAHSDbContext context)
        {
            _cGTContext = context;
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            try
            {
                var Model = await _cGTContext.Set<TEntity>().AddAsync(entity);
                await _cGTContext.SaveChangesAsync();
                return Model.Entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TEntity> Delete(TEntity entity)
        {
            var Model = _cGTContext.Set<TEntity>().Remove(entity);
            await _cGTContext.SaveChangesAsync();
            return Model.Entity;
        }

        public Task<TEntity> Get(int id)
        {

            throw new NotImplementedException();
        }



        public List<TEntity> Get()
        {
            try
            {
                return _cGTContext.Set<TEntity>().Where(x => true).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            try
            {
                var Model = _cGTContext.Set<TEntity>().Update(entity);
                await _cGTContext.SaveChangesAsync();
                return Model.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
