namespace StudentSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        private ICollection<Student> students;
        private ICollection<Course> courses;

        public Homework()
        {
            this.students = new HashSet<Student>();
            this.courses = new HashSet<Course>();
        }

        public int HomeworkID { get; set; }
        public string Content { get; set; }
        public DateTime TimeSent { get; set; }

        [ForeignKey("Student")]
        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
        
        [ForeignKey("Course")]
        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }
    }
}