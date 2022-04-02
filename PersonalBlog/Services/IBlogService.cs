using PersonalBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Services
{
    public interface IBlogService
    {
        //List<BlogPost> GetLatestPosts();
        List<Post> GetLatestPosts();
        //List<BlogPost> GetOlderPosts(int olderBlogPostId);
        List<Post> GetOlderPosts(int olderBlogPostId);
        string GetPostText(string link);
    }
}
