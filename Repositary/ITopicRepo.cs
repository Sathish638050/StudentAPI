using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
    public interface ITopicRepo<Topic>
    {
        public Task<List<Topic>> Topics(int id);
    }
}
