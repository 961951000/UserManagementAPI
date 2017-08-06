using Microsoft.AspNetCore.Mvc;

namespace UserManagementAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UploadController : Controller
    {
        public string Image()
        {
            return "Upload image";
        }

        public string File()
        {
            return "Upload File";
        }
    }
}