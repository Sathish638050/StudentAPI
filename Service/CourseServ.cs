using StudentApi.Model;
using StudentApi.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
    public class CourseServ : ICourseServ<Course>
    {
        private readonly ICourseRepo<Course> repo;
        public CourseServ(ICourseRepo<Course> _repo)
        {
            repo = _repo;
        }

        public Task<List<Course>> GetAllCourse()
        {
            return repo.GetAllCourse();
        }

        public Task<Course> GetCourseById(int id)
        {
            return repo.GetCourseById(id);
        }

        public Task<List<Course>> MyCourses(int id)
        {
            return repo.MyCourses(id);
        }
    }
}
