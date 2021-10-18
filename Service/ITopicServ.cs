using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
    public interface ITopicServ<Topic>
    {
        public Task<List<Topic>> Topics(int id);
    }
}
