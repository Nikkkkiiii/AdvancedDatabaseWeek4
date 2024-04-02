using System.ComponentModel.DataAnnotations;

namespace AdvancedDatabaseWeek4
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; } 
        public string? Email {  get; set; }
        public string? Phone { get; set; }
    }
}
