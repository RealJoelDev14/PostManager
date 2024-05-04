using Microsoft.EntityFrameworkCore;
using PostManager.Domain.Comments;
using PostManager.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.Infrastructure.Common.Persistence
{
    public class PostManagerContext:DbContext
    {
        public PostManagerContext(DbContextOptions<PostManagerContext> options):base(options)
        {
            
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostManagerContext).Assembly);
        }
    }
}
