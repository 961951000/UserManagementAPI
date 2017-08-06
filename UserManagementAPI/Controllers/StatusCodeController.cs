using Microsoft.AspNetCore.Mvc;

namespace UserManagementAPI.Controllers
{
    public class StatusCodeController : Controller
    {
        [HttpGet("api/status_code/Emails")]
        public string Emails()
        {
            return "Generate a active email to user";
        }

        [HttpGet("api/status_code/Users/{UserId}/Info")]
        public string Info(int userId)
        {
            return "Update user info, like profile";
        }

        [HttpGet("api/status_code/Users/{UserId}/Password")]
        public string Password(int userId)
        {
            return "Update user password";
        }
    }
}