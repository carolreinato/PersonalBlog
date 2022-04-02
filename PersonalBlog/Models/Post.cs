using MongoDB.Bson;
using PersonalBlog.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Models
{
    public class Post
    {
        public ObjectId _id { get; set; }
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Link
        {
            get
            {
                return ShortDescription.UrlFriendly(50);
            }
            set
            {
            }
        }
        public string Text { get; set; }
    }
}
