using System;
using System.Linq;
using System.Linq.Expressions;

namespace OnlineShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        //marks an entity as new
        void Add(T entity);

        //marks an entity as modified
        void Update(T entity);

        //marks an entity to be removed
        void Delete(T entity);

        //delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        //get an entity by int id
        T GetSingleByID(int ID);

        //get an entity by condition
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        // get all records
        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}