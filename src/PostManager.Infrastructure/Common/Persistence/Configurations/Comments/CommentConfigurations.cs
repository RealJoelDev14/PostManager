using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostManager.Domain.Comments;
using PostManager.Domain.Comments.ValueObjects;
using PostManager.Domain.Posts.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.Infrastructure.Common.Persistence.Configurations.Comments
{
    public class CommentConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(c=> c.Id);
            builder.Property(c => c.Id).
                HasColumnName("CommentId").
                ValueGeneratedNever().
                HasConversion(c => c.Value, value => CommentId.Create(value));
            builder.Property(x => x.PostId).
            HasColumnName("PostId").
            ValueGeneratedNever().
            HasConversion(x => x.Value, value => PostId.Create(value));

        }
    }
}
