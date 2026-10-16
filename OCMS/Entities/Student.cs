using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseManagement.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
