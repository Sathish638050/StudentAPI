using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
    public interface ICourseServ<Course>
    {
        public Task<List<Course>> MyCourses(int id);
        public Task<List<Course>> GetAllCourse();
        public Task<Course> GetCourseById(int id);
    }
}
