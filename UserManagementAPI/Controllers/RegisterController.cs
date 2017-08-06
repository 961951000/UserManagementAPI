using Microsoft.AspNetCore.Mvc;

namespace UserManagementAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class RegisterController : Controller
    {
        public new string User()
        {
            return "User register by user info";
        }

        public string Tenant()
        {
            return "Tenant register by tenant info";
        }
    }
}