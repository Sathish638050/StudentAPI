using StudentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repositary
{
    public class TopicRepo : ITopicRepo<Topic>
    {

        private readonly ITopic<Topic> obj;
        public TopicRepo(ITopic<Topic> _obj)
        {
            obj = _obj;
        }
        public Task<List<Topic>> Topics(int id)
        {
            return obj.Topics(id);
        }
    }
}
