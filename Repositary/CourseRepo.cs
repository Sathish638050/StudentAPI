using StudentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
    public class CourseRepo : ICourseRepo<Course>
    {
        private readonly ICourse<Course> obj;
        public CourseRepo(ICourse<Course> _obj)
        {
            obj = _obj;
        }

        public Task<List<Course>> GetAllCourse()
        {
            return obj.GetAllCourse();
        }

        public Task<Course> GetCourseById(int id)
        {
            return obj.GetCourseById(id);
        }

        public Task<List<Course>> MyCourses(int id)
        {
            return obj.MyCourses(id);
        }
    }
}
