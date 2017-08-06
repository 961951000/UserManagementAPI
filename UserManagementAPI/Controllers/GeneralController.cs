using Microsoft.AspNetCore.Mvc;

namespace UserManagementAPI.Controllers
{
    public class GeneralController : Controller
    {


        [HttpGet("api/General/User/{UserId}")]
        public new string User(int userId)
        {
            return "Get specified user info";
        }

        [HttpGet("api/General/Users")]
        public string Users(int top, int skip)
        {
            return "Get the numbers of user list from {skip}";
        }

        [HttpGet("api/General/Tenant/{TenantId}")]
        public string Tenant(int tenantId)
        {
            return "Get specified tenant info";
        }

        [HttpGet("api/General/Tenants")]
        public string Tenants(int top, int skip)
        {
            return "Get the numbers of tenant list from {skip}";
        }

        [HttpGet("api/General/Users/{UserId}/Emails/{Email}")]
        public string Emails(int userId, int email)
        {
            return "Activating the user by email with guid provided";
        }
    }
}