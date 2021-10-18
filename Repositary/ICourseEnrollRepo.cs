using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
   public  interface ICourseEnrollRepo<CourseEnroll>
    {
        public void Enrolls(CourseEnroll s);
    }
}
