using StudentApi.Model;
using StudentApi.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
    public class CourseEnrollServ:ICourseEnrollServ<CourseEnroll>
    {
        private readonly ICourseEnrollRepo<CourseEnroll> repo;
        public CourseEnrollServ(ICourseEnrollRepo<CourseEnroll> _repo)
        {
            repo = _repo;
        }

        public void Enrolls(CourseEnroll s)
        {
            repo.Enrolls(s);
        }
    }
}
