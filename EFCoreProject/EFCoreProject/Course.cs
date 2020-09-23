using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fee { get; set; }
        public List<Student> CourseStudents { get; set; }
    }
}
