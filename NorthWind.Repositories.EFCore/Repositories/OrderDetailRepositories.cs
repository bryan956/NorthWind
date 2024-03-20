using NorthWind.Entities.Interfaces;
using NorthWind.Entities.POCOEntities;
using NorthWind.Repositories.EFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Repositories.EFCore.Repositories
{
    public class OrderDetailRepositories : IOrderDetailRepository
    {
        readonly NorthWindContext Context;
        public OrderDetailRepositories(NorthWindContext context) => Context = context;
        public void create(OrderDetail orderDitail)
        {
            Context.Add(orderDitail);
        }
    }
}
