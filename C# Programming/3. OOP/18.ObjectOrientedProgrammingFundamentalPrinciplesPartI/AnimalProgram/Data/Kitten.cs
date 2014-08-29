namespace AnimalProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Kitten : Cat
    {
        public Kitten()
        {
            _name = null;
            _age = int.MinValue;
            _sex = 'f';
        }

        public Kitten(string name, int age)
        {
            _name = name;
            _age = age;
            _sex = 'f';
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
                    throw new ArgumentNullException("Kitten must have name!");
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
                    throw new ArgumentException("Age can't be under 0!");
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
