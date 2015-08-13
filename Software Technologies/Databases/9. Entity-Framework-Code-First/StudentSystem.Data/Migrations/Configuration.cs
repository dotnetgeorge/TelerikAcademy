namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Model;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemEntities>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentSystemEntities context)
        {
            context.Students.AddOrUpdate(new Student { Name = "Test One", Number = 1});
            context.Courses.AddOrUpdate(new Course
            {
                Name = "Test Course",
                Description = "This is just test course.",
                Materials = "In this course we don't have any materials",
            });
            context.Homeworks.AddOrUpdate(new Homework { Content = "This is empty homework.", TimeSent = DateTime.Now});
        }
    }
}
