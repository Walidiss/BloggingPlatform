using BloggingPlatform.Models;

namespace BloggingPlatform.Interfaces
{
    public interface IPostBlogService
    {
        Task<BlogPost> CreatePost(BlogPost blogPost);

        Task DeletePostById(int id);
        Task<IEnumerable<BlogPost>> GetAllPosts();

        Task<BlogPost> GetPostById(int id);
        Task<List<BlogPost>> GetPostByTerm(string term);

        Task UpdatePost(BlogPost blogPost);
    }
}
