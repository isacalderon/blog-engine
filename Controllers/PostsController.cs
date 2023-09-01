// controller to do the crud in Posts
using Microsoft.AspNetCore.Mvc;
using blog_engine.Repository; 

namespace blog_engine.Controllers;

[ApiController]
public class PostsController: ControllerBase{

    private readonly ILogger<PostsController> _logger;

    private readonly BlogEngineContext _context;

    public PostsController(ILogger<PostsController> logger, BlogEngineContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("posts", Name = "GetPosts")]
    public IActionResult Get()
    {
        _logger.LogInformation("GetPosts");
        var posts = _context.Posts.ToList();
        _logger.LogInformation($"GetPosts: {posts.Count}");
       return Ok(posts); 
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