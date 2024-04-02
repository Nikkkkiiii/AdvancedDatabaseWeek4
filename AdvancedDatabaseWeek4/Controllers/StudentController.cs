using AdvancedDatabaseWeek4.Service;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedDatabaseWeek4.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpPost, Route("AddStudent")]
        public async Task<IActionResult> AddStudent(Student student)
        {
            var addStudent = await _studentService.AddStudent(student);
            return Ok(addStudent);
        }


        [HttpDelete, Route("DeleteStudent/{id}")]
        public async Task<IActionResult> DeleteStudent(string id)
        {
            await _studentService.DeleteStudent(id);
            return Ok();
        }

        [HttpPut, Route("UpdateStudent/{id}")]
        public async Task<IActionResult> UpdateStudent(string id, Student updatedStudent)
        {
            if (updatedStudent == null)
            {
                return BadRequest("Invalid student data.");
            }
            var result = await _studentService.UpdateStudent(updatedStudent);
            if (result == null) 
            {
                return NotFound();
            }

            return Ok(result);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
