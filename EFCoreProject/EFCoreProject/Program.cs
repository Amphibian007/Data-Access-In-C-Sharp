using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFCoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=DESKTOP-QNQ23OO;Database=CSharpHome;User Id=dipto_user;Password=1234567; ";
            var migrationAssemblyName = typeof(Program).Assembly.FullName;
            var context = new FrameworkContext(connectionString, migrationAssemblyName);
            var student = GetStudent(context, 3);
            Console.WriteLine(student.name);

            student.cgpa = 3.3;

            context.SaveChanges();

            context.Students.Remove(student);
            context.SaveChanges();
        }

        public static Student GetStudent(FrameworkContext context, int id)
        {
           var student= context.Students.Where(x => x.Id == id).FirstOrDefault();
            return student;
        }

        public static void AddStudent(FrameworkContext context)
        {
            var newStudent = new Student
            {
                name = "Sujan",
                cgpa = 2.9,
                MobileNumber = "01871414911",
                Address = "Dhaka, Bangladesh"
            };
            context.Students.Add(newStudent);
            context.SaveChanges();
        }

        public static void CreateCourseAndStudent(FrameworkContext context)
        {
            var course = new Course
            {
                Title = "C# Fundamental",
                Fee = 6000,
            };
            var student = new Student
            {
                name = "Dipto",
                MobileNumber = "01986228955",
                cgpa = 3.2,
                Address = "Gazipur, Bangladesh"
            };

            course.CourseStudents = new List<Student>();
            course.CourseStudents.Add(student);

            context.Courses.Add(course);
            context.SaveChanges();
        }
    }
}
