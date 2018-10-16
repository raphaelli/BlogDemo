using BlogDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDemo.Core.Interface
{
    interface IPostRepository
    {
        IEnumerable<Post> GetAllPost();
    }
}
