namespace StudentSystem.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Model;
    using System.Data.Entity;
    using StudentSystem.Data.Migrations;

    public class TestClient
    {
        static void Main(string[] args)
        {
            using (var studentSystem = new StudentSystemEntities())
            {
                Homework homework = new Homework() 
                {
                    Content = "No homework. It's summer!",
                    TimeSent = DateTime.Now
                };
                Student student = new Student() 
                {
                    Name = "Name Test",
                    Number = 15
                };

                List<Student> students = new List<Student>();
                students.Add(student);
                List<Homework> homeworks = new List<Homework>();
                homeworks.Add(homework);

                Course course = new Course() 
                { 
                    Name = "FirstTest",
                    Description = "Just description!",
                    Materials = "No materials",
                    Students = students,
                    Homework = homeworks
                };

                studentSystem.Courses.Add(course);
                studentSystem.SaveChanges();
            }
        }    
    }
}
