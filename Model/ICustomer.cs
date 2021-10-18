using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Model
{
    public interface ICustomer<Customer>
    {
        public void MakePayment(Customer c);
    }
}
