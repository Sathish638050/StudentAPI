using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
    public interface IUserAccountServ<UserAccount>
    {
        public Task<UserAccount> Profile(int id);
        public Task<UserAccount> GetById(int id);
        public Task<UserAccount> Update(int id);
    }
}
