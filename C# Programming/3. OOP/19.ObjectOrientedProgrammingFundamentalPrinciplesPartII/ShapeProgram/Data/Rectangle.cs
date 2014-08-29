namespace ShapeProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    class Rectangle : Shape
    {
        public Rectangle()
        {
            _height = double.MinValue;
            _width = double.MinValue;
        }

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public override double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Height can't be under 1!");
                }
                _height = value;
            }
        }

        public override double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Width can't be under 1!");
                }
            }
        }

        public override double CalculateSurface()
        {
            return (_height * _width);
        }
    }
}
