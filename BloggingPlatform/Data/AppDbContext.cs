using BloggingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BloggingPlatform.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<BlogPost> blogPosts { get; set; }
    }
}
