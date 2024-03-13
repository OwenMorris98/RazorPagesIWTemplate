using Microsoft.AspNetCore.Http;
namespace RazorPagesIWTemplate.Auth.Services

{
    public class AuthService : IAuthService
    {

        private readonly IHttpContextAccessor _httpContext;

        public AuthService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public string GetUserName()
        {
            var user = _httpContext.HttpContext.User;
            var isAuthenticated = user.Identity.IsAuthenticated;

            return _httpContext.HttpContext.User.Identity.Name;

        }


    }

}
