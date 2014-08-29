namespace HumanProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
        {
            _firstName = firstName;
            _lastName = lastName;
            this.grade = grade;
        }

        public override string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("First name must be filled!");
                }
                _firstName = value;
            }
        }

        public override string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Last name must be filled!");
                }
                _lastName = value;
            }
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Grade can be only in range 2-6!");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return String.Format("First name: {0}\nLast name: {1}\nGrade: {2}\n", _firstName, _lastName, grade);
        }
    }
}
