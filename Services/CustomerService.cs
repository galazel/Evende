using Evende.Model;
using Evende.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evende.Services
{
    internal class CustomerService
    {
        private CustomerRepository repository = new CustomerRepository();
        public void AddCustomer(CustomerModel customerModel)
        {
            repository.AddCustomer(customerModel);
        }


    }
}
