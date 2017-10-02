using System;

namespace shapes
{
    class Triangle
    {
        private double height;
        private double baseLength;

        public Triangle()
        {
            this.height = 1;
            this.baseLength = 1;
        }

        public Triangle(double Jordan, double Harold)
        {
            this.height = Jordan;
            this.baseLength = Harold;
        }

        

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if(value < 1 || value > double.MaxValue)
                {
                    throw new OverflowException();
                }
                height = value;
            }

        }
        
        public double BaseLength
        {
            get
            {
                return baseLength;
            }

            set
            {
                if(value < 1 || value > double.MaxValue)
                {
                    throw new OverflowException();
                }
                baseLength = value;
            }
        }
        public double GetArea()
        {
            return (height * baseLength) * 0.5;
        }

        public double GetPerimeter()
        {
            return baseLength+(Math.Sqrt((baseLength*baseLength)+(4*height)*height));
        }
    }
}