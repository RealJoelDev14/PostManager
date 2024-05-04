using PostManager.Domain.Comments.ValueObjects;
using PostManager.Domain.Common.Models;
using PostManager.Domain.Posts.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.Domain.Comments
{
    public sealed class Comment:Entity<CommentId>
    {
        public PostId PostId { get; private set; }
        public string Content { get; private set; }

        private Comment(CommentId id,string content):base(id) 
        {
            Content = content;
            
        }

        public static Comment Create(string content)
        {
            return new Comment(CommentId.CreateUnique(), content);
        }
        public void SetContent(string content)
        {
            Content = content;
        }
        private Comment()
        {
            
        }
    }
}
