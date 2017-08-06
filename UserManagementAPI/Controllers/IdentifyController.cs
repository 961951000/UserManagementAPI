using Microsoft.AspNetCore.Mvc;

namespace UserManagementAPI.Controllers
{
    public class IdentifyController : Controller
    {
        [HttpGet("api/Identify/Users/{UserId}/Tokens")]
        public string Tokens(int userId)
        {
            return "Binding token for user's service, like wps, adobe, office365, etc.";
        }

        [HttpGet("api/Identify/Users/{UserId}/Bindings")]
        public string Bindings(int userId)
        {
            return "Binding token for user's service, like wechat, alipay, etc.";
        }
    }
}