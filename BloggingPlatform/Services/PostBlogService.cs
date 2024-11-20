using BloggingPlatform.Interfaces;
using BloggingPlatform.Models;
using BloggingPlatform.Repository.Interface;

namespace BloggingPlatform.Services
{
    public class PostBlogService : IPostBlogService
    {
        private readonly IBlogPostRepository _blogPostRepository;
        private readonly ILogger _logger;

        public PostBlogService(IBlogPostRepository blogPostRepository, ILogger<PostBlogService> logger)
        {
            _blogPostRepository = blogPostRepository;
            _logger = logger;
        }
        public async Task<BlogPost> CreatePost(BlogPost blogPost)
        {
            try
            {
                await _blogPostRepository.AddAsync(blogPost);
                return blogPost;
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
            }
            return blogPost;
        }

        public async Task DeletePostById(int id)
        {
            try
            {
                await _blogPostRepository.DeleteByIdAsync(id);
            }

            catch (Exception ex) { 
                _logger.LogWarning(ex.Message);
            }
        }

        public async Task<IEnumerable<BlogPost>> GetAllPosts()
        {
            try
            {
             return   await _blogPostRepository.GetAll();
            }

            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
                throw;
            };
        }

        public async Task<BlogPost> GetPostById(int id)
        {
            try
            {
                return await _blogPostRepository.GetById(id);
            }

            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
                throw;
            }
        }

        public async Task<List<BlogPost>> GetPostByTerm(string term)
        {
            try
            {
                return await _blogPostRepository.GetByTerm(term);
            }

            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
                throw;
            }
        }
        public async Task UpdatePost(BlogPost blogPost)
        {
            try
            {
                 await _blogPostRepository.UpdateAsync(blogPost);
            }

            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
                throw;
            }
        }
    }
}
