using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using PersonalBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Repositoty
{
    public class PostRepository : IPostRepository
    {
        private readonly IMongoCollection<Post> _postCollection;
        public PostRepository(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["ConnectionString"]);
            var db = client.GetDatabase("Post");
            _postCollection = db.GetCollection<Post>("Post");
        }

        public List<Post> GetPosts()
        {
            var collection = _postCollection.Find(new BsonDocument()).ToList();
            return collection;
        }
    }
}
