namespace ShapeProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        protected double _width;
        protected double _height;

        public virtual double CalculateSurface()
        {
            return _width * _height;
        }

        public abstract double Width
        {
            get;
            set;
        }

        public abstract double Height
        {
            get;
            set;
        }
    }
}
