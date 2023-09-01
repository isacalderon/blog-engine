// controller to do the crud in Posts
using Microsoft.AspNetCore.Mvc;

namespace blog_engine.Controllers;

[ApiController]
public class PostsController: ControllerBase{

    private readonly ILogger<PostsController> _logger;

    public PostsController(ILogger<PostsController> logger)
    {
        _logger = logger;
    }

    [HttpGet("posts", Name = "GetPosts")]
    public IEnumerable<Posts> Get()
    {
        throw new NotImplementedException();
    }

    [HttpGet("posts/{id}", Name = "GetPost")]
    public Posts Get(int id)
    {
       throw new NotImplementedException();
    }

    [HttpPost("posts", Name = "CreatePost")]
    public Posts Create(Posts post)
    {
        throw new NotImplementedException();
    }

    [HttpPut("posts/{id}", Name = "UpdatePost")]
    public Posts Update(int id, Posts post)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("posts/{id}", Name = "DeletePost")]
    public Posts Delete(int id)
    {
       throw new NotImplementedException();
    }

}