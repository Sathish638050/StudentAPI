using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Model
{
   public interface IClass<Class>
    {
        public Task<List<Class>> GetStudentClass(int id);
    }
}
