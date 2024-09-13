using AutoMapper;
using SampleAPI.Dto_s;
using SampleAPI.Models.Entities;
using SampleAPI.Repository;

namespace SampleAPI.Services
{
    public class StudentService : IStudentService
    {
        private IStudentrepository _studentRepository;
        private IMapper _mapper;

        public StudentService(IStudentrepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<StudentDto>> getAll()
        {
           var student= await _studentRepository.getAll();
             return _mapper.Map<IEnumerable<StudentDto>>(student);
        }

        public async Task<StudentDto> save(StudentDto studentdto)
        {
            var student = _mapper.Map<Student>(studentdto);
        var savedstudent= await _studentRepository.save(student);
            return _mapper.Map<StudentDto>(savedstudent);
        }
    }
}
