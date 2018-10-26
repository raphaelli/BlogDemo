using BlogDemo.Core.Entities;
using BlogDemo.Infrastructure.DataBase.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BlogDemo.Infrastructure.DataBase
{
    public class MyContext:DbContext
    {
        //自定义DbContext 并调用父类的 options
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PostConfiguration());
        }

        public DbSet<Post> Posts { get; set; }
    }
}
