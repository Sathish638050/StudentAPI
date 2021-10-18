using StudentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
    public class CourseEnrollRepo:ICourseEnrollRepo<CourseEnroll>
    {
        private readonly ICourseEnroll<CourseEnroll> obj;
        public CourseEnrollRepo(ICourseEnroll<CourseEnroll> _obj)
        {
            obj = _obj;
        }

        public void Enrolls(CourseEnroll s)
        {
            obj.Enrolls(s);
        }
    }
}
