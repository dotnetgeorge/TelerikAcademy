namespace SchoolProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Class : Student
    {
        private char identifier;
        private List<Student> students = new List<Student>();

        public Class()
        {
            this.identifier = char.MinValue;
        }

        public Class(char identifier)
        {
            this.identifier = identifier;
        }

        public char Identifier
        {
            get { return this.identifier; }
            set
            {
                if (char.IsNumber(value) || char.IsDigit(value) || char.IsWhiteSpace(value))
                {
                    throw new ArgumentException("Identifier can't be digit!");
                }
                this.identifier = value;
            }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("Students in class must be filled!");
                }
                this.students = value;
            }
        }


        public void AddStudent(string name, int numberInClass)
        {
            this.Students.Add(new Student(name, numberInClass));
        }

        public void RemoveStudent(string name)
        {
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].StudentName == name)
                {
                    this.Students.RemoveAt(i);
                }
            }
        }

        public void ShowClass()
        {
            Console.WriteLine("Class identifier: " + this.identifier);
            for (int i = 0; i < this.Students.Count; i++)
            {
                Console.WriteLine("Student name: " + this.Students[i].StudentName);
                Console.WriteLine("Student number in class: " + this.Students[i].NumberInClass);
            }
        }

        public override string ToString()
        {
            string result = "Class identifier: " + this.identifier + "\n";
            for (int i = 0; i < this.Students.Count; i++)
            {
                result += this.Students[i].ToString();
            }
            return result;
        }
    }
}
