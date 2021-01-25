using MasterDetail.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Infrastructure.Repository
{
    public class ItemRepository:GenericRepository<tblItem>
    {
        public ItemRepository(TestdbEntities context): base(context)
        {

        }

        //public override tblItem Update(tblItem entity)
        //{
        //    var Item = context.tblItems.Single(i => i.id == entity.id);
        //    Item.varName = entity.varName;
        //    Item.intPrice = entity.intPrice;
        //    return base.Update(Item);
        //}
    }
}
