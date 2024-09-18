using AD_SSO_Test.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AD_SSO_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ActiveDirectoryService _adService;

        public AuthController(ActiveDirectoryService adService)
        {
            _adService = adService;
        }

        [Authorize]
        [HttpGet]
        public string Get()
        {
            var username = User.Identity?.Name;
            if((!string.IsNullOrEmpty(username)) && (username != "error")) {
                return "User logged is: " + username;
            }
            return "Error: User not found";
        }
    }
}
