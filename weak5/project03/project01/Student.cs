using System.Collections.Generic;

namespace StudentManagementSystem
{
    public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty; 
        public int Age { get; set; } 
        public string Email { get; set; } = string.Empty; 

        public int DepartmentId { get; set; } 

        // Navigation Properties 
        public virtual Department? Department { get; set; } 
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>(); 
    }
}