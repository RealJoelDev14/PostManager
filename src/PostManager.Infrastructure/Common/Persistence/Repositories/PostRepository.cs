using Microsoft.EntityFrameworkCore;
using PostManager.ApplicationCore.Common.Persistence;
using PostManager.Domain.Common.Models;
using PostManager.Domain.Posts;
using PostManager.Domain.Posts.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.Infrastructure.Common.Persistence.Repositories
{
    public class PostRepository : IPostRepository
    {
        private PostManagerContext _dbContext;
        public PostRepository(PostManagerContext dbContext)
        {
            _dbContext = dbContext;
            
        }
        public async Task AddAsync(Post entity, CancellationToken cancellationToken)
        {
           await _dbContext.AddAsync(entity, cancellationToken);
           await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Post>> GetAllAsync(CancellationToken cancellationToken)
        {
           return await _dbContext.Posts.AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task<Post> GetByIdAsync(PostId id, CancellationToken cancellationToken)
        {
            return await _dbContext.Posts.Where(p => p.Id == id).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task RemoveAsync(Post entity, CancellationToken cancellationToken)
        {
             _dbContext.Posts.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(List<Post> entities, CancellationToken cancellationToken)
        {
            _dbContext.Posts.RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Post entity, CancellationToken cancellationToken)
        {
            _dbContext.Posts.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
