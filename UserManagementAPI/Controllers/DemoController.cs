using System;
using log4net;
using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;

namespace UserManagementAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DemoController : Controller
    {
        private readonly ILog _log = LogManager.GetLogger(Startup.Repository.Name, typeof(DemoController));

        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            _log.Debug($"Demo start --- {DateTime.Now}");
            var user = new User
            {
                UserId = DateTime.Now.Second,
                Account = "caixiangwei@beyondsoft.com",
                Password = "This is a secret",
                UserName = "Xiangwei"
            };
            _log.Debug($"Demo end --- {DateTime.Now}");

            return Json(user);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
