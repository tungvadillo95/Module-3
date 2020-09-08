using CustomerManager.Models;
using CustomerManager.Models.Entity;
using CustomerManager.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerManagerDb context;

        public CustomerService(CustomerManagerDb context)
        {
            this.context = context;
        }
        public int CreateCustomer(Customer customer)
        {
            context.Customers.Add(customer);
           return context.SaveChanges();
        }

        public int DeleteCustomer(int id)
        {
            var deleteCustomer = GetCustomer(id);
            if (deleteCustomer != null)
            {
                context.Customers.Remove(deleteCustomer);
                return context.SaveChanges();
            }
            return -1;
        }

        public Customer GetCustomer(int id)
        {
            return context.Customers.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<CustomerView> GetCustomers()
        {
            IEnumerable<CustomerView> customers = new List<CustomerView>();
            customers = (from c in context.Customers
                         join p in context.Provinces on c.ProvinceId equals p.id
                         select (new CustomerView()
                         {
                             Id = c.Id,
                             Name = c.Name,
                             Address = c.Address,
                             Phone = c.Phone,
                             ProvinceName = p._name
                         }));
            return customers;
        }

        public IEnumerable<Province> GetProvinces()
        {
            return context.Provinces;
        }

        public int UpdateCustomer(RegisterView model)
        {
            var customer = GetCustomer(model.Id);
            if (customer == null)
            {
                return -1;
            }
            customer.Name = model.Name;
            customer.Address = model.Address;
            customer.Phone = model.Phone;
            customer.ProvinceId = model.ProvinceId;

            context.Update(customer);
            return context.SaveChanges();
        }
    }
}
