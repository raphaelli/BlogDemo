using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogDemo.Infrastructure.DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogDemo.API.Controllers
{
    [Route("api/posts")]
    public class PostController : Controller
    {
        private readonly MyContext _myContext;
        public PostController(MyContext myContext)
        {
            _myContext = myContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var posts = await _myContext.Posts.ToListAsync();
            return Ok(posts);
        }
    }
}