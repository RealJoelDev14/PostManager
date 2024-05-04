using PostManager.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.Domain.Posts.ValueObjects
{
    public class PostId:EntityId<Guid>
    {
        private PostId(Guid value):base(value)
        {
            
        }

        public static PostId Create(Guid value)
        {
            return new PostId(value);
        }
        public static PostId CreateUnique()
        {
            return new PostId(Guid.NewGuid());
        }
    }
}
