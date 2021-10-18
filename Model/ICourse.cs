using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Model
{
    public interface ICourse<Course>
    {
        public Task<List<Course>> MyCourses(int id);
        public Task<List<Course>> GetAllCourse();
        public Task<Course> GetCourseById(int id);
    }
}
