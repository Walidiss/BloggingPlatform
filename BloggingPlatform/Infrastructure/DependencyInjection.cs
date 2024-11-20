using BloggingPlatform.Data;
using BloggingPlatform.Interfaces;
using BloggingPlatform.Repository.Interface;
using BloggingPlatform.Repository.Services;
using BloggingPlatform.Services;
using Microsoft.EntityFrameworkCore;

namespace BloggingPlatform.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services
                .AddPersistance();
            services.AddScoped<IPostBlogService, PostBlogService>();
            return services;

        }

        public static IServiceCollection AddPersistance(
            this IServiceCollection services) {

            //services.AddDbContext<AppDbContext>(options =>

            //options.UseSqlServer("DefaultConnection")
            //);
            services.AddScoped<IBlogPostRepository, BlogPostRepository>();
        
            return services;
        }


      


    }
}
