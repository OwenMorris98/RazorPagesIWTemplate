using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesIWTemplate.Auth.Services;
using RazorPagesIWTemplate.Data;

namespace RazorPagesIWTemplate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IApplicationDbContext _context;

        private readonly IAuthService _authService;

        public IndexModel(ILogger<IndexModel> logger, IApplicationDbContext context, IAuthService authService)
        {
            _logger = logger;
            _context = context;
            _authService = authService;
        }

        public void OnGet()
        {
           string name = _authService.GetUserName();

        }
    }
}
