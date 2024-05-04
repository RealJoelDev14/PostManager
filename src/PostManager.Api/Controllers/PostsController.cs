using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostManager.ApplicationCore.Posts.Commands.CreatePost;
using PostManager.ApplicationCore.Posts.Queries.ListPosts;

namespace PostManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ISender _mediator;
        public PostsController(ISender mediator)
        {
            _mediator = mediator;            
        }
        [HttpPost]
        public async Task<IActionResult> Create(string title,string content)
        {
            var command= new CreatePostCommand(title, content);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new ListPostsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
