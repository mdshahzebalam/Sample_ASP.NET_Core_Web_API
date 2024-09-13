using SampleAPI.Models.Entities;
using System.Collections.Generic;

namespace SampleAPI.Repository
{
    public interface IStudentrepository
    {
        Task<IEnumerable<Student>> getAll();
        Task<Student> save(Student student);

    }
}
