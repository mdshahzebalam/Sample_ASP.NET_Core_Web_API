using Microsoft.EntityFrameworkCore;
using SampleAPI.Data;
using SampleAPI.Models.Entities;

namespace SampleAPI.Repository
{
    public class StudentRepository : IStudentrepository
    {
        private ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Student>> getAll()
        {
          return await _context.students.ToListAsync();
        }

        public async Task<Student> save(Student student)
        {
            var s= await _context.AddAsync(student);
            return s.Entity;
        }
    }
}
