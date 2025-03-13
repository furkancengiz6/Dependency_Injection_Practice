using Dependency_Injection_Practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_Practice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassRoomController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public ClassRoomController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet("info")]
        public IActionResult GetInfo() 
        {
            var info = _teacher.GetInfo();
            return Ok(info);
        }

    }
}
