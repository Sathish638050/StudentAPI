using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

#nullable disable

namespace StudentApi.Model
{
    public partial class Class:IClass<Class>
    {
        public int ClassId { get; set; }
        public int CourseId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Clink { get; set; }
        public DateTime ClassDate { get; set; }

        public virtual Course Course { get; set; }
        public ELearnApplicationContext db = new ELearnApplicationContext();

        public async Task<List<Class>> GetStudentClass(int id)
        {
            List<Class> lc = new List<Class>();

            lc = (from i in db.CourseEnrolls
                       join j in db.Classes
                           on i.CourseId equals j.CourseId
                       where i.UserId == id
                       select j).ToList();
            return lc;
        }
    }
}
