namespace ExeptionProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InvalidRangeException<T> : Exception
    {
        public T Start 
        { 
            get; 
            set; 
        }

        public T End
        {
            get;
            set;
        }

        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
