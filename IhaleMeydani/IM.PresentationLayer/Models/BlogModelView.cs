using IM.PresentationLayer.IhaleWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Models
{
    public class BlogModelView
    {
        public List<tag> Tags { get; set; }
        public List<tag_post> Tags_posts { get; set; }
        public List<Post> Posts { get; set; }
    }
}