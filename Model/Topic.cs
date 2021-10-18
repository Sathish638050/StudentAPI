using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

#nullable disable

namespace StudentApi.Model
{
    public partial class Topic:ITopic<Topic>
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public string TopicDesc { get; set; }
        public string MaterialPath { get; set; }
        public string VideoPath { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public ELearnApplicationContext db = new ELearnApplicationContext();
        public async Task<List<Topic>> Topics(int id)
        {
            List<Topic> modDetail = new List<Topic>();

            modDetail = (from i in db.Topics
                         where i.CourseId == id
                         select i).ToList();

            return modDetail;
        }
    }
}
