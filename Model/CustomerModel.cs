using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evende.Model
{
    internal class CustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerAddress { get; set; }
        public string ContactNumber { get; set; }
        public string PasswordHash { get; set; }

        public string Email { get; set; }


    }
}
