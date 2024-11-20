using BloggingPlatform.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace BloggingPlatform.Repository.Interface
{
    public interface IBlogPostRepository
    {
         Task AddAsync(BlogPost blogPost);

        Task DeleteByIdAsync(int id);
        Task<IEnumerable<BlogPost>> GetAll();

        Task<BlogPost> GetById(int id);
        Task<List<BlogPost>> GetByTerm(string term);

        Task UpdateAsync(BlogPost blogPost);
    }
}
