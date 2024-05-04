using PostManager.Domain.Common.Models;
using PostManager.Domain.Posts.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.Domain.Posts
{
    public sealed class Post:Entity<PostId>
    {
        public string Title { get; private set; }
        public string Description { get; private set; }

        private Post(PostId id,string title,string description):base(id) 
        {
            Title = title;
            Description = description;
            
        }

        public static Post Create(string title,string description)
        {
            return new Post(PostId.CreateUnique(),title,description);
        }
        public void SetTitle(string title)
        {
            Title = title;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }

        private Post()
        {
            
        }

    }
}
