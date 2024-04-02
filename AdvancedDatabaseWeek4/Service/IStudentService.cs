namespace AdvancedDatabaseWeek4.Service
{
    public interface IStudentService
    {
        Task<Student> AddStudent(Student student);
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> UpdateStudent(Student student);
        Task DeleteStudent(string id);
        Task<IEnumerable<Student>> GetStudentById(string id);
    }
}
