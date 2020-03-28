using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [Route("user")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User user = new User();
            user.Age = 24;
            user.Email = "tania.mahajan@nagarro.com";
            user.Name = "Tania Mahajan";
            return Ok(user);
        }
    }
}
