using HelpDesk_Application.BaseContract;
using System.Linq.Expressions;

namespace HelpDesk_Infrastructure.BaseRepositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
