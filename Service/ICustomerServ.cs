using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
    public interface ICustomerServ<Customer>
    {
        public void MakePayment(Customer c);
    }
}
