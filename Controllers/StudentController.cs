using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApi.Model;
using StudentApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       
        private readonly IClassServ<Class> CS;
        private readonly IUserAccountServ<UserAccount> US;
        private readonly ICourseServ<Course> COS;
        private readonly ITopicServ<Topic> TS;
        private readonly ICustomerServ<Customer> CUS;
        private readonly ICourseEnrollServ<CourseEnroll> CES;
        public StudentController(IClassServ<Class> _CS, IUserAccountServ<UserAccount> _US, ICourseServ<Course> _COS, ITopicServ<Topic> _TS, ICustomerServ<Customer> _CUS, ICourseEnrollServ<CourseEnroll> _CES)
        {
          
            CS= _CS;
            US = _US;
            COS = _COS;
            TS = _TS;
            CUS = _CUS;
            CES=_CES;
        }
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(StudentController));
        public ELearnApplicationContext db = new ELearnApplicationContext();
        [HttpGet]
        public async Task<IActionResult> StudentsHome(int id)
        {
            _log4net.Info("Home Page Viewed");
            List<Course> courseDetail = new List<Course>();
            var registered = (from i in db.CourseEnrolls where i.UserId == id select i.CourseId).ToList();
            courseDetail = (from i in db.Courses where !registered.Contains(i.CourseId) select i).ToList();
            return Ok(courseDetail);
        }
       
        [HttpPost("CourseEnroll")]
        public async Task<IActionResult> Enrolls(CourseEnroll s)
        {
            _log4net.Info(s.UserId+"Enrolled"+s.CourseId);
            CES.Enrolls(s);
            return Ok();
        }
        [HttpGet]
        [Route("GetEnrollCourses")]
        public async Task<IActionResult> MyCoursesAsync(int myid)
        {

            _log4net.Info("My courses Page Viewed");
            List<Course> MyDetail = new List<Course>();

            MyDetail = await COS.MyCourses(myid); 
            return Ok(MyDetail);
        }
        [HttpGet]
        [Route("Topics")]
        public async Task<IActionResult> Topics(int cid)
        {
            List<Topic> modDetail = new List<Topic>();

            modDetail = await TS.Topics(cid);
            
            return Ok(modDetail);
        }
        [HttpGet]
        [Route("UserProfile")]
        public async Task<IActionResult> Profile(int userid)
        {
            UserAccount profile = await US.Profile(userid);
            return Ok(profile);
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, UserAccount s)
        {
            _log4net.Info(id+" was edit profile");
            UserAccount pro = await US.Update(id);
            if(pro!=null)
            {
                
                pro.Email = s.Email;
                pro.FirstName = s.FirstName;
                pro.LastName = s.LastName;
            }
            //db.Entry(s).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser(int id,UserAccount s)
        {
            _log4net.Info(id + "user are update detail");
            UserAccount p = db.UserAccounts.Find(id);
            p.Email = s.Email;
            p.FirstName = s.FirstName;
            p.LastName = s.LastName;
            p.Phone = s.Phone;
            //db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }
        [HttpPut]
        [Route("UpdateUserPic")]
        public async Task<IActionResult> UpdatePic(int id, UserAccount s)
        {
            _log4net.Info(id + " was edit profile picture");
            UserAccount u = db.UserAccounts.Find(id);
            u.UserImage = s.UserImage;
            db.SaveChanges();
            return Ok();
            
        }
        [HttpGet]
        [Route("GetStudentByID")]
        public async Task<ActionResult<UserAccount>> GetById(int id)
        {
            UserAccount e = await US.GetById(id);
            return Ok(e);
        }
        [HttpGet]
        [Route("Class")]
        public async Task<IActionResult> GetClass(int id)
        {
            //List<CourseEnroll> co = new List<CourseEnroll>();
            List<Class> c = new List<Class>();
            var date = DateTime.Now;
          //  co = (from i in db.CourseEnrolls where i.UserId == id select i).ToList();
            c = (from i in db.Classes
                 join j in db.CourseEnrolls on i.CourseId equals j.CourseId where j.UserId==id && i.ClassDate == date
                 select i).ToList();
            return Ok(c);
        }
        [HttpGet]
        [Route("GetCourseById")]
        public async Task<IActionResult> GetCourseById(int id)
        {
            Course obj = new Course();
            obj = await COS.GetCourseById(id);
            return Ok(obj);
        }
        [HttpGet("GetAllCourse")]
        public async Task<IActionResult> GetAllCourse()
        {
            List<Course> course = new List<Course>();
            course = await COS.GetAllCourse();
            return Ok(course);
        }
        [HttpPost("MakePayment")]
        public async Task<IActionResult> MakePayment(Customer c)
        {
             CUS.MakePayment(c);
           
            return Ok();
        }
        [HttpGet("GetStudentClass")]
        public async Task<IActionResult> GetStudentClass(int id)
        {
            List<Class> lc = new List<Class>();
            lc = await CS.GetStudentClass(id);
            return Ok(lc);
        }
    }
}
