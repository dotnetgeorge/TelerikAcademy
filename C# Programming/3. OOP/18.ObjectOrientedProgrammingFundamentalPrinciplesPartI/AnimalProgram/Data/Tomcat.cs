namespace AnimalProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Tomcat : Cat
    {
        public Tomcat()
        {
            _name = null;
            _age = int.MinValue;
            _sex = 'm';
        }

        public Tomcat(string name, int age)
        {
            _name = name;
            _age = age;
            _sex = 'm';
        }

        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Tomcat must have name!");
                }
                _name = value;
            }
        }

        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Tomcat can't have age under 0!");
                }
                _age = value;
            }
        }

        public override char Sex
        {
            get
            {
                return _sex;
            }
        }
    }
}
