using System.Collections.Generic;
using WebSim.Domain.Customers;

namespace WebSim.Application.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetTopActiveCustomers(int count);

        IEnumerable<Customer> GetAllCustomersData();
    }
}