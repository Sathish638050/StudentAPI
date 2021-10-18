using System;
using System.Collections.Generic;

#nullable disable

namespace StudentApi.Model
{
    public partial class Customer:ICustomer<Customer>
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Debit { get; set; }
        public int Cvv { get; set; }
        public string Expiry { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual UserAccount User { get; set; }
        public ELearnApplicationContext db = new ELearnApplicationContext();
        public async void MakePayment(Customer c)
        {
            await db.Customers.AddAsync(c);
            await db.SaveChangesAsync();
        }
    }
}
