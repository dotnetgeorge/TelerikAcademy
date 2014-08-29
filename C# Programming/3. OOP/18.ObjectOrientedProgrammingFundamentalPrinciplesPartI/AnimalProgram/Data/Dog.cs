namespace AnimalProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Dog : Animal
    {
        public Dog()
        {
            _name = null;
            _age = int.MinValue;
            _sex = char.MinValue;
        }

        public Dog(string name, int age, char sex)
        {
            _name = name;
            _age = age;
            _sex = sex;
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
                    throw new ArgumentNullException("Dog name must be filled!");
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
                    throw new ArgumentException("Dog age can't be under 0!");
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
            set
            {
                if (char.ToLower(value) != 'm' || char.ToLower(value) != 'f')
                {
                    throw new ArgumentException("Wrong information about sex!");
                }
                _sex = value;
            }
        }

        public override string Sound()
        {
            return "Bow-bow";
        }
    }
}
