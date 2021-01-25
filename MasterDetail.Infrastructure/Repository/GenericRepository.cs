using MasterDetail.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Infrastructure.Repository
{
    public  class GenericRepository<T> : IRepository<T> where T : class
    {
        protected TestdbEntities context;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this.context = new TestdbEntities();
            table = context.Set<T>();
        }

        public GenericRepository(TestdbEntities context)
        {
            this.context = context;
            table = context.Set<T>();
        }
        public  T Add(T entity)
        {
            return table.Add(entity);
        }

        public  IEnumerable<T> All()
        {
            return table.ToList();
        }

        public  IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public  T Get(T id)
        {
            return table.Find(id);
        }

        public  void SaveChanges()
        {
            context.SaveChanges();
        }

        public  T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
