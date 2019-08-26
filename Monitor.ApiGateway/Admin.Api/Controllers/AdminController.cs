namespace Admin.Api
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/admins")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "admin1", "admin2" };
        }
    }
}
