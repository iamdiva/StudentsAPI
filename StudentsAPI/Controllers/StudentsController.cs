using Microsoft.AspNetCore.Mvc;
using StudentsAPI.BisinessLayer;

namespace StudentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        IStudenService _studenService;
        public StudentsController(IStudenService studenService)
        {
            _studenService = studenService;
        }

        [HttpPost("data")]
        public IActionResult GetStudentData()
        {            
            return Ok(_studenService.GetStudents());
        }
    }
}
