namespace GSMProgramVersionTwo.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Display
    {
        private float size;
        private long numberOfColors;

        public Display()
        {
            this.size = float.MinValue;
            this.numberOfColors = long.MinValue;
        }

        public Display(float size, long numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public float Size
        {
            get { return this.size; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Screen size can't be uner 1 inch.");
                }
                this.size = value;
            }
        }

        public long NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Number of colors can't be under 1.");
                }
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            string result = "\nDisplay Size: " + this.size;
            result += "\nNumber of colors: " + this.numberOfColors;

            return result;
        }
    }
}
