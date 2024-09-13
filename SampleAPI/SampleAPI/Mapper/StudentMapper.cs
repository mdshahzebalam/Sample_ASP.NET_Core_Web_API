using AutoMapper;

using SampleAPI.Dto_s;
using SampleAPI.Models.Entities;

namespace SampleAPI.Mapper
{
    public class StudentMapper : Profile
    {
        public StudentMapper()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
        }

    }
}
