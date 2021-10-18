using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
    public interface ICustomerRepo<Customer>
    {
        public void MakePayment(Customer c);
    }
}
