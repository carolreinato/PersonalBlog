using PersonalBlog.Models;
using System.Collections.Generic;

namespace PersonalBlog.Repository
{
    public interface IPostRepository
    {
        List<Post> GetPosts();
        Post Create(Post post);
        bool Update(Post post);
        public bool Delete(Post post);
    }
}
