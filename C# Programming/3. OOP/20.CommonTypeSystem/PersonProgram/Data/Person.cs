using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProgram.Data
{
    class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.name = null;
            this.age = int.MinValue;
        }

        public Person(string name)
        {
            this.name = name;
            this.age = int.MinValue;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name must be filled!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can't be under 0!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            string result = "Name: " + this.name + "\n";
            if (this.age < 0)
            {
                result += "Age is left unspecified.";
            }
            else
            {
                result += "Age: " + this.age + "\n";
            }
            return result;
        }
    }
}
