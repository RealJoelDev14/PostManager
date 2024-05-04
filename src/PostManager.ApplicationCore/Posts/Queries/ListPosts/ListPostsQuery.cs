using MediatR;
using PostManager.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.ApplicationCore.Posts.Queries.ListPosts
{
    public record ListPostsQuery():IRequest<List<Post>>;
}
