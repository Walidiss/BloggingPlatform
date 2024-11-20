using BloggingPlatform.Common.Exceptions;
using BloggingPlatform.Data;
using BloggingPlatform.Models;
using BloggingPlatform.Repository.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using System;

namespace BloggingPlatform.Repository.Services
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly AppDbContext appDbContext;
        public BlogPostRepository(AppDbContext dbContext)
        {
            appDbContext = dbContext;         
        }

        public async Task AddAsync(BlogPost blogPost)
        {
            appDbContext.Add(blogPost);
            await appDbContext.SaveChangesAsync();
      
        }

        public async Task DeleteByIdAsync(int id)
        {
            var post = appDbContext.blogPosts.FirstOrDefault(x => x.Id == id);
            if (post == null) {
                throw new NotFoundException(nameof(BlogPost),id);
            }
            appDbContext.Remove(post);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlogPost>> GetAll()
        {
           return appDbContext.blogPosts.ToList();
           
        }

        public async Task<BlogPost> GetById(int id)
        {
            return  appDbContext.blogPosts.AsEnumerable().First(x => x.Id == id);
        }
        public async Task<List<BlogPost>> GetByTerm(string term)
        {
            return appDbContext.blogPosts.Where(x => x.Tags.Contains(term)).ToList();
        }
        public async Task UpdateAsync(BlogPost blogPost)
        {  
            var post = appDbContext.blogPosts.AsEnumerable().First(x =>x.Id == blogPost.Id);
            post.Title = blogPost.Title;
            post.Content = blogPost.Content;
            post.category = blogPost.category;
            post.UpdatedAt = DateTime.Now;
            post.CreatedAt = blogPost.CreatedAt;
            //foreach (var tag in blogPost.Tags) { 
            //post.Tags.Add(tag);
            
            //}
           appDbContext.blogPosts.Update(post);
            await appDbContext.SaveChangesAsync();
        }
    }
}
