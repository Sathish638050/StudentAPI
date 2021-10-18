using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace StudentApi.Model
{
    public partial class Course:ICourse<Course>
    {
        public Course()
        {
            Classes = new HashSet<Class>();
            CourseEnrolls = new HashSet<CourseEnroll>();
            Customers = new HashSet<Customer>();
            Fees = new HashSet<Fee>();
            Topics = new HashSet<Topic>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }

        public virtual UserAccount User { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<CourseEnroll> CourseEnrolls { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
        public ELearnApplicationContext db = new ELearnApplicationContext();
        public async Task<List<Course>> MyCourses(int id)
        {
            List<Course> MyDetail = new List<Course>();

            MyDetail = (from i in db.Courses
                        join cd in db.CourseEnrolls on i.CourseId equals cd.CourseId
                        where cd.UserId == id
                        select i).ToList();
            return MyDetail;
        }

        public async Task<List<Course>> GetAllCourse()
        {
            List<Course> course = new List<Course>();
            course = await db.Courses.ToListAsync();
            return course;
        }

        public async Task<Course> GetCourseById(int id)
        {
            Course obj = new Course();
            obj =  db.Courses.Find(id);
            return obj;
        }
    }
}
