using Microsoft.AspNetCore.Mvc;

namespace blog_engine.Controllers;

[ApiController]
public class CommentController: ControllerBase{

    private readonly ILogger<CommentController> _logger;

    public CommentController(ILogger<CommentController> logger)
    {
        _logger = logger;
    }

    [HttpGet("comments", Name = "GetComments")]
    public IEnumerable<Comments> Get()
    {
        throw new NotImplementedException();
    }

    [HttpPost("comments", Name = "CreateComment")]
    public Comments Create(Comments comment)
    {
        throw new NotImplementedException();
    }
    
    [HttpDelete("comments/{id}", Name = "DeleteComment")]
    public Comments Delete(int id)
    {
       throw new NotImplementedException();
    }

}