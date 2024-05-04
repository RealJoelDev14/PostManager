using MediatR;
using PostManager.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.ApplicationCore.Posts.Commands.CreatePost
{
    public record CreatePostCommand
    (
        string Title,
        string Description        
    ):IRequest<Post>;
}
