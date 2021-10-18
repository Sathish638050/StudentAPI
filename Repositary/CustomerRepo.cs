using StudentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
    public class CustomerRepo:ICustomerRepo<Customer>
    {
        private readonly ICustomer<Customer> obj;
        public CustomerRepo(ICustomer<Customer> _obj)
        {
            obj = _obj;
        }

        public void MakePayment(Customer c)
        {
            obj.MakePayment(c);
        }
    }
}
