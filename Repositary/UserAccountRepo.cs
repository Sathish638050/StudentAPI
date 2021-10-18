using StudentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
    public class UserAccountRepo : IUserAccountRepo<UserAccount>
    {
        private readonly IUserAccount<UserAccount> obj;
        public UserAccountRepo(IUserAccount<UserAccount> _obj)
        {
            obj = _obj;
        }

        public Task<UserAccount> GetById(int id)
        {
            return obj.GetById(id);
        }

        public Task<UserAccount> Profile(int id)
        {
            return obj.Profile(id);
        }

        public Task<UserAccount> Update(int id)
        {
            return obj.Update(id);
        }
    }
}
