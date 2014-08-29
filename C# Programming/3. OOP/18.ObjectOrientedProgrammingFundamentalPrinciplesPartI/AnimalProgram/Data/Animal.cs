namespace AnimalProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Animal : ISound
    {
        protected string _name;
        protected int _age;
        protected char _sex;

        public abstract string Name
        {
            get;
            set;
        }

        public abstract int Age
        {
            get;
            set;
        }

        public abstract char Sex
        {
            get;
            set;
        }

        public virtual string Sound()
        {
            return "....";
        }
    }
}
