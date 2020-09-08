using CustomerManager.Models;
using CustomerManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Controllers
{
    public class CustomerController : GeneralController<Customer, ICustomerService>

    {



        public CustomerController(ICustomerService service) : base(service)

        {



        }

    }

}
