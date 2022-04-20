using Microsoft.AspNetCore.Hosting;
using PersonalBlog.Models;
using PersonalBlog.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Services.Impl
{
    public class BlogServiceImpl : IBlogService
    {
        private readonly IPostRepository _postRepository;

        public BlogServiceImpl(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        private List<Post> GetLastOrderingPosts(IEnumerable<Post> query)
        {
            return query.OrderByDescending(x => x.PostId).Take(3).ToList();
        }

        public List<Post> GetLatestPosts()
        {
            var result = _postRepository.GetPosts();
            return result;
        }

        public List<Post> GetOlderPosts(int olderBlogPostId)
        {
            var posts = _postRepository.GetPosts();
            var query = posts.Where(post => post.PostId < olderBlogPostId);
            return GetLastOrderingPosts(query);
        }

        public string GetPostText(string link)
        {
            var posts = _postRepository.GetPosts();
            var text = posts.FirstOrDefault(x => x.Link == link).Text;
            return text;
        }
    }
}
