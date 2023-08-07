using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly ICurrentUserService _currentUser;


        public AccountController(ILogger<AccountController> logger, ICurrentUserService currentUser)
        {
            _logger = logger;
            _currentUser = currentUser;
        }

        
        [Authorize]
        [HttpGet(Name = "CurrentUserInfo")]
        public IActionResult CurrentUserInfo()
        {
            return Ok(new
            {
                _currentUser.Email,
                _currentUser.FullName
            });
        }

    }
}