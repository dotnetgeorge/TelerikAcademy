namespace ShapeProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Circle : Shape
    {
        private double radius;
        public Circle()
        {
            _height = double.MinValue;
            _width = double.MinValue;
        }

        public Circle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public override double Height
        {
            get { return _height; }
            set 
            {
                if (value != _width)
                {
                    throw new ArgumentException("Height and Width must be the same!");
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
                if (value != _height)
                {
                    throw new ArgumentException("Width and Height must be the same!");
                }
                _width = value;
            }
        }

        public override double CalculateSurface()
        {
            double result = Math.PI * (_height * _width);
            return result;
        }
    }
}
