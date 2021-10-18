using StudentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
    public class ClassRepo : IClassRepo<Class>
    {
        private readonly IClass<Class> obj;
        public ClassRepo(IClass<Class> _obj)
        {
            obj = _obj;
        }
        public Task<List<Class>> GetStudentClass(int id)
        {
            return obj.GetStudentClass(id);
        }
    }
}
