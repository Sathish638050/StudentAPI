using StudentApi.Model;
using StudentApi.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
    public class ClassServ : IClassServ<Class>
    {
        private readonly IClassRepo<Class> repo;
        public ClassServ(IClassRepo<Class> _repo)
        {
            repo = _repo;
        }
        public Task<List<Class>> GetStudentClass(int id)
        {
            return repo.GetStudentClass(id);
        }
    }
}
