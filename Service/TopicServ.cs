using StudentApi.Model;
using StudentApi.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Service
{
    public class TopicServ : ITopicServ<Topic>
    {
        private readonly ITopicRepo<Topic> repo;
        public TopicServ(ITopicRepo<Topic> _repo)
        {
            repo = _repo;
        }
        public Task<List<Topic>> Topics(int id)
        {
            return repo.Topics(id);
        }
    }
}
