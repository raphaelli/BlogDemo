using BlogDemo.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogDemo.Infrastructure.DataBase
{
    public class MyContext:DbContext
    {
        //自定义DbContext 并调用父类的 options
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}
