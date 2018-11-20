using BlogDemo.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogDemo.Core.interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllPostsAstnc();

        void addPost(Post post);
    }
}