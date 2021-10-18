using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
   public interface ICourseEnrollServ<CourseEnroll>
    {
        public void Enrolls(CourseEnroll s);
    }
}
