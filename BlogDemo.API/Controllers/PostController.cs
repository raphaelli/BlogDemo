using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogDemo.Core.Entities;
using BlogDemo.Core.interfaces;
using BlogDemo.Infrastructure.DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogDemo.API.Controllers
{
    [Route("api/posts")]
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IUnitOfWork _unitOfWork;


        public PostController(IPostRepository postRepository,IUnitOfWork unitOfWork)
        {
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var posts = await _postRepository.GetAllPostsAstnc();
            return Ok(posts);
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var newPost = new Post()
            {
                Author = "Admin",
                Body = "Tetst!@#!@#!@#!@$!AWEQWEVQWfaewqeqjkweyuqiwoeuioqwueio1231",
                Title = "Test!",
                LastModified = DateTime.Now
            };

            //执行操作
            _postRepository.addPost(newPost);

            //通过Unit of work 持久化数据
            await _unitOfWork.SaveAsync(); 

            return Ok();
        }
    }
}