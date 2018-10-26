using BlogDemo.Core.interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using BlogDemo.Infrastructure.DataBase;
using BlogDemo.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlogDemo.API
{
    public class StartupDevelopment
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //在开发环境中使用SqlLite
            services.AddDbContext<MyContext>(options => 
            {
                options.UseSqlite("Data Source=BlogDemo.db");
            });

            services.AddHttpsRedirection(options => 
            {
                options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                options.HttpsPort = 5001;
            });

            //注册Repository 和 Unit Of  Work
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
