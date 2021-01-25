using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Infrastructure.Repository
{
   public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Get(T id);
        IEnumerable<T> All();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void SaveChanges();
    }
}
