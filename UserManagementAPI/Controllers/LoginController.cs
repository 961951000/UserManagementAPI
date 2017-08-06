using Microsoft.AspNetCore.Mvc;

namespace UserManagementAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class LoginController : Controller
    {
        public new string User()
        {
            return "User login by password";
        }

        public string Tenant()
        {
            return "Tenant login by password";
        }
    }
}