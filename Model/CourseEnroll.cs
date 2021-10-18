using System;
using System.Collections.Generic;

#nullable disable

namespace StudentApi.Model
{
    public partial class CourseEnroll:ICourseEnroll<CourseEnroll>
    {
        public int EnrollId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual UserAccount User { get; set; }
        public ELearnApplicationContext db = new ELearnApplicationContext();

        public async void Enrolls(CourseEnroll s)
        {
            await db.CourseEnrolls.AddAsync(s);
            await db.SaveChangesAsync();
        }
    }
}
