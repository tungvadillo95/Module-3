using CustomerManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Repositories.Impl
{
    public class CustomerRepositoryImpl : GeneralRepositoryImpl<Customer, DataContext>, ICustomerRepository

    {

        public CustomerRepositoryImpl(DataContext context) : base(context)

        {



        }
    }
}
