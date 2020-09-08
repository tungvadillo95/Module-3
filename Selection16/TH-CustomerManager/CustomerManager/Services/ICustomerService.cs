using CustomerManager.Models.Entity;
using CustomerManager.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Services
{
    public interface ICustomerService
    {
        IEnumerable<Province> GetProvinces();
        int CreateCustomer(Customer customer);
        IEnumerable<CustomerView> GetCustomers();
        Customer GetCustomer(int id);
        int UpdateCustomer(RegisterView model);
        int DeleteCustomer(int id);
    }
}
