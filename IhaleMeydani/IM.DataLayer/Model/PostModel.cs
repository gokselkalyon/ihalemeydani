using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataLayer.Model
{
    public class PostModel
    {
        public int Post_id { get; set; }
        public int content_id { get; set; }
        public int users_id { get; set; }
        public DateTime? Post_date { get; set; }
        public int submit_id { get; set; }
        public int media_id { get; set; }
        public string submit_article { get; set; }
        public int id { get; set; }
        public string image_name { get; set; }
        public string image_subtitle { get; set; }
        public string image_title { get; set; }
        public string image_path { get; set; }
    }
}
//Post_id	content_id	users_id	Post_date	submit_id	media_id	submit_article	id	image_name	image_subtitle	image_title	image_path