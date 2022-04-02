using PersonalBlog.Models;
using System.Collections.Generic;

namespace PersonalBlog.Repositoty
{
    public interface IPostRepository
    {
        List<Post> GetPosts();
        Post Create(Post post);
        bool Update(Post post);
        public bool Delete(Post post);
    }
}
