using CustomerManager.Models;
using CustomerManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Services.Impl
{
    public class CustomerServiceImpl : GeneralServiceImpl<Customer, ICustomerRepository>, ICustomerService
    {
        public CustomerServiceImpl(ICustomerRepository repository) : base(repository)
        {

        }
    }
}
