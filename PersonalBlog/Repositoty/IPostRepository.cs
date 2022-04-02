using PersonalBlog.Models;
using System.Collections.Generic;

namespace PersonalBlog.Repositoty
{
    public interface IPostRepository
    {
        List<Post> GetPosts();
    }
}
