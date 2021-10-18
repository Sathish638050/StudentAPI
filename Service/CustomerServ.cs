using StudentApi.Model;
using StudentApi.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
    public class CustomerServ:ICustomerServ<Customer>
    {
        private readonly ICustomerRepo<Customer> repo;
        public CustomerServ(ICustomerRepo<Customer> _repo)
        {
            repo = _repo;
        }

        public void MakePayment(Customer c)
        {
            repo.MakePayment(c);
        }
    }
}
