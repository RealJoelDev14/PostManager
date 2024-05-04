using PostManager.Domain.Posts;
using PostManager.Domain.Posts.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.ApplicationCore.Common.Persistence
{
    public interface IPostRepository:IBaseRepository<PostId,Post>
    {
    }
}
