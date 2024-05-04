using MediatR;
using PostManager.ApplicationCore.Common.Persistence;
using PostManager.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.ApplicationCore.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Post>
    {
        private readonly IPostRepository _postRepository;
        public CreatePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
            
        }
        public async Task<Post> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = Post.Create(request.Title, request.Description);
            await _postRepository.AddAsync(post,cancellationToken);
            return post;
        }
    }
}
