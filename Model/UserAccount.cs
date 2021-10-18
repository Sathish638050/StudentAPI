using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

#nullable disable

namespace StudentApi.Model
{
    public partial class UserAccount:IUserAccount<UserAccount>
    {
        public UserAccount()
        {
            Answers = new HashSet<Answer>();
            CourseEnrolls = new HashSet<CourseEnroll>();
            Courses = new HashSet<Course>();
            Customers = new HashSet<Customer>();
            Fees = new HashSet<Fee>();
            Questions = new HashSet<Question>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string UserImage { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<CourseEnroll> CourseEnrolls { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public ELearnApplicationContext db = new ELearnApplicationContext();
        public async Task<UserAccount> Profile(int userid)
        {
            UserAccount profile = (from i in db.UserAccounts
                                   where i.UserId == userid
                                   select i).FirstOrDefault();
            return profile;
        }

        public async Task<UserAccount> GetById(int id)
        {
            UserAccount e = await db.UserAccounts.FindAsync(id);
            return e;
        }

        public async Task<UserAccount> Update(int id)
        {
            UserAccount p = await db.UserAccounts.FindAsync(id);
            return p;
        }
    }
}
