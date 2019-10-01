using Microsoft.EntityFrameworkCore;
using WebSim.Application.Interfaces;
using WebSim.Domain.Orders;

namespace WebSim.Persistence.Orders
{
    public class OrdersRepository : Repository<Order>, IOrdersRepository
    {
        public OrdersRepository(DbContext context) : base(context)
        { }

        private DatabaseService _appContext => (DatabaseService)_context;
    }
}