using System.Collections.Generic;
using System.Threading.Tasks;

namespace EAHS.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        public Task<TEntity> Create(TEntity entity);
        public Task<TEntity> Update(TEntity entity);
        public Task<TEntity> Delete(TEntity entity);
        public List<TEntity> Get();
        public Task<TEntity> Get(int id);
    }
}
