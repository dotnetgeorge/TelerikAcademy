namespace StudentSystem.Data
{
    using System;
    using System.Collections.Generic;
    using StudentSystem.Model;
    using System.Data.Entity;
    using StudentSystem.Data.Mapping;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using StudentSystem.Data.Migrations;

    public class StudentSystemEntities : DbContext
    {
        public StudentSystemEntities()
            : base("StudentSystem")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemEntities, Configuration>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new StudentMapping());
            modelBuilder.Configurations.Add(new CourseMapping());
            modelBuilder.Configurations.Add(new HomeworkMapping());
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}