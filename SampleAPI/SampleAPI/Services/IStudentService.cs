using SampleAPI.Dto_s;
using SampleAPI.Models.Entities;

namespace SampleAPI.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> getAll();
        Task<StudentDto> save(StudentDto studentdto);
    }
}
