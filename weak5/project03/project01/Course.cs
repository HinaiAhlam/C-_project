using System.Collections.Generic;

namespace StudentManagementSystem
{
    public class Course
    {
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty; 
        public int Hours { get; set; } 

        // Many-to-Many Relationship 
        public virtual ICollection<Student> Students { get; set; } = new List<Student>(); 
    }
}