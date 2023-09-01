using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using blog_engine.Services;

[ApiController]
[Route("api/[controller]")]
public class AuthController: ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    private readonly IConfiguration _configuration;
    private readonly IOauthService _oauthService;
    public AuthController(IConfiguration configuration, IOauthService oauthService, ILogger<AuthController> logger)
    {
        _configuration = configuration;
        _oauthService = oauthService;
        _logger = logger;
    }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult Auth([FromBody] UserDto user)
    {
        _logger.LogInformation("Auth");
        _logger.LogInformation($"Auth: {user.email}");
        if (user == null)
        {
            return BadRequest("Invalid client request");
        }

        OauthResponse response = _oauthService.GetToken(user.email, user.password); 
        if (response.code.Equals("401"))
        {
            return Unauthorized(response);
        }
        else
        {
            return Ok(response);
        }
       
    }
}
