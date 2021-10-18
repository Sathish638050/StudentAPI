using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Model
{
    public interface ICourseEnroll<CourseEnroll>
    {
        public void Enrolls(CourseEnroll s);
    }
}
