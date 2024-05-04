using MediatR;
using PostManager.ApplicationCore.Common.Persistence;
using PostManager.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.ApplicationCore.Posts.Queries.ListPosts
{
    public class ListPostsQueryHandler : IRequestHandler<ListPostsQuery, List<Post>>
    {
        private readonly IPostRepository _postRepository;
        public ListPostsQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<List<Post>> Handle(ListPostsQuery request, CancellationToken cancellationToken)
        {
           return await _postRepository.GetAllAsync(cancellationToken);
        }
    }
}
