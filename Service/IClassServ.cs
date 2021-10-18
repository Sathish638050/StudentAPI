using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
  public  interface IClassServ<Class>
    {
        public Task<List<Class>> GetStudentClass(int id);
    }
}
