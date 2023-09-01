
using blog_engine.Dto;

namespace blog_engine.Services;
public interface IOauthService
{
    OauthResponse GetToken(string userName, string password);
}