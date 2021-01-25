using MasterDetail.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Infrastructure.Repository
{
   public class CustomerRepository:GenericRepository<tblCustomer>

    {
        public CustomerRepository(TestdbEntities context) : base(context)
        {

        }
        public  tblCustomer Update(tblCustomer entity)
        {
            var customer = context.tblCustomers.Single(i => i.id == entity.id);
            customer.varName = entity.varName;
            customer.varAddress = entity.varAddress;
            return base.Update(customer);
        }
    }
}
