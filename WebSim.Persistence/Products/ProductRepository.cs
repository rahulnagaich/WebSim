using Microsoft.EntityFrameworkCore;
using WebSim.Application.Interfaces;
using WebSim.Domain.Products;

namespace WebSim.Persistence.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        { }

        private DatabaseService _appContext => (DatabaseService)_context;
    }
}