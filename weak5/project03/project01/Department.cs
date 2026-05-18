using System.Collections.Generic;

namespace StudentManagementSystem
{
    public class Department
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty; 

        // One-to-Many Relationship 
        public virtual ICollection<Student> Students { get; set; } = new List<Student>(); 
    }
}