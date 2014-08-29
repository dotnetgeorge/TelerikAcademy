namespace HumanProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Human
    {
        protected string _firstName;
        protected string _lastName;

        public abstract string FirstName
        {
            get;
            set;
        }

        public abstract string LastName
        {
            get;
            set;
        }
    }
}
