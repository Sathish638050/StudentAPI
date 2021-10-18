using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
   public  interface IClassRepo<Class>
    {
        public Task<List<Class>> GetStudentClass(int id);
    }
}

