using Microsoft.AspNetCore.Mvc;

namespace UserManagementAPI.Controllers
{
    public class PrivilegeController : Controller
    {
        [HttpGet("api/Privilege/Users/{UserId}")]
        public string Users(int userId)
        {
            return "Remove individual user by user id";
        }

        [HttpGet("api/Privilege/Users/Active")]
        public string Active()
        {
            return "Active individual user by user id";
        }

        [HttpGet("api/Privilege/Users/Deactive")]
        public string Deactive()
        {
            return "Deactive individual user by user id";
        }
    }
}