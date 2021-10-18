using StudentApi.Model;
using StudentApi.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
    public class UserAccountServ : IUserAccountServ<UserAccount>
    {
        private readonly IUserAccountRepo<UserAccount> repo;
        public UserAccountServ(IUserAccountRepo<UserAccount> _repo)
        {
            repo = _repo;
        }

        public Task<UserAccount> GetById(int id)
        {
            return repo.GetById(id);
        }

        public Task<UserAccount> Profile(int id)
        {
            return repo.Profile(id);
        }

        public Task<UserAccount> Update(int id)
        {
            return repo.Update(id);
        }
    }
}
