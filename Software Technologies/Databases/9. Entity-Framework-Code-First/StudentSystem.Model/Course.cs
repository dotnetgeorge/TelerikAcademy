namespace StudentSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Course
    {
        private ICollection<Student> students;

        public Course()
        {
            this.students = new HashSet<Student>();
        }

        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Materials { get; set; }

        [ForeignKey("Student")]
        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        [ForeignKey("Homework")]
        public int HomeworkID { get; set; }
        public virtual ICollection<Homework> Homework { get; set; }
    }
}