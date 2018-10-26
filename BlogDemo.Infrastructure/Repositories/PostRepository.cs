using System.Collections.Generic;
using System.Threading.Tasks;
using BlogDemo.Core.Entities;
using BlogDemo.Core.interfaces;
using BlogDemo.Infrastructure.DataBase;
using Microsoft.EntityFrameworkCore;

namespace BlogDemo.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly MyContext _myContext;
        public PostRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public async Task<IEnumerable<Post>>GetAllPostsAstnc()
        {
            return await _myContext.Posts.ToListAsync();
        }

        public void addPost(Post post)
        {
            _myContext.Add(post);
        }
    }
}