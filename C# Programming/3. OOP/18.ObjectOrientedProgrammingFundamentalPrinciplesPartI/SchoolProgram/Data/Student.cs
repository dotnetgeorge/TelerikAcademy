namespace SchoolProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Student : Teacher
    {
        private string name;
        private int numberInClass;

        public Student()
        {
            this.name = null;
            this.numberInClass = int.MinValue;
        }

        public Student(string name, int numberInClass)
        {
            this.name = name;
            this.numberInClass = numberInClass;
        }

        public string StudentName
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Student name must be filled!");
                }
                this.name = value;
            }
        }

        public int NumberInClass
        {
            get { return this.numberInClass; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Numbers start at 1!");
                }
                this.numberInClass = value;
            }
        }

        public override string ToString()
        {
            string result = "Student name: " + this.name + "\n";
            result += "Student number in class: " + this.numberInClass + "\n";
            return result;
        }
    }
}
