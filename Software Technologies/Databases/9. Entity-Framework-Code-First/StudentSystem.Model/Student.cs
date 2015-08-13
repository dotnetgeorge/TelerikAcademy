namespace StudentSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {
        private ICollection<Course> courses;

        public Student()
        {
            this.courses = new HashSet<Course>();
        }

        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        [ForeignKey("Course")]
        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        [ForeignKey("Homework")]
        public int HomeworkID { get; set; }
        public virtual Homework Homework { get; set; }
    }
}