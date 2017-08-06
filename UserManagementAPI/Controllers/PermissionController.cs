using Microsoft.AspNetCore.Mvc;

namespace UserManagementAPI.Controllers
{
    public class PermissionController : Controller
    {
        [HttpGet("api/Permission/Tenants/{TenantId}/Add")]
        public string Add(int tenantId)
        {
            return "Add individual user for a specified tenant";
        }

        [HttpGet("api/Permission/Tenants/{TenantId}/Users/{UserId}")]
        public string Users(int tenantId, int userId)
        {
            return "Remove individual user for a specified tenant";
        }

    }
}