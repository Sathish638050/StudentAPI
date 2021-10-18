using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Model
{
   public interface ITopic<Topic>
    {
        public Task<List<Topic>> Topics(int id);
    }
}
