using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Dto_s;
using SampleAPI.Services;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;
           public StudentController(IStudentService studentService)
            {
            _studentService=studentService;
            }
        [HttpGet("getAll")]
        public async Task<IEnumerable<StudentDto>> getAll()
        {
            return await _studentService.getAll();
        }

        [HttpPost("save")]
        public async Task<StudentDto> getAll(StudentDto studentdto)
        {
            return await _studentService.save(studentdto);
        }

    }
}
