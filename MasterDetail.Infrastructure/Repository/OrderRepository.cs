using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MasterDetail.Domain;

namespace MasterDetail.Infrastructure.Repository
{
    public class OrderRepository : GenericRepository<tblOrder>
    {
        public OrderRepository(TestdbEntities context) : base(context)
        {

        }
        //public override IEnumerable<tblOrder> Find(Expression<Func<tblOrder, bool>> predicate)
        //{
        //    return context.tblOrders.Include(t => t.tblOrderDetails).Where(predicate).ToList();
        //}

    }
}
