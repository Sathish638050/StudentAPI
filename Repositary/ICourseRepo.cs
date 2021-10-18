using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
    public interface ICourseRepo<Course>
    {
        public Task<List<Course>> MyCourses(int id);
        public Task<List<Course>> GetAllCourse();
        public Task<Course> GetCourseById(int id);
    }
}
