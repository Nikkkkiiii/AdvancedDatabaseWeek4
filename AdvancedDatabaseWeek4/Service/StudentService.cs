
using Microsoft.EntityFrameworkCore;

namespace AdvancedDatabaseWeek4.Service
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDBContext _dbContext;

        public StudentService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Student> AddStudent(Student student)
        {
            var result = await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteStudent(string id)
        {
            var student = await _dbContext.Students.Where(e => e.Id.ToString() == id).FirstOrDefaultAsync();
            if (student != null)
            {
                _dbContext.Students.Remove(student);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<Student> UpdateStudent(Student student)
        {
            var init_student = await _dbContext.Students.FirstOrDefaultAsync(s => s.Id == student.Id);
            if (init_student != null)
            {
                init_student.Name = student.Name;
                init_student.Email = student.Email;
                init_student.Phone = student.Phone;
                init_student.Gender = student.Gender;
                await _dbContext.SaveChangesAsync();
                return init_student;
            }
            return null;
        }

        public Task<IEnumerable<Student>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetStudentById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
