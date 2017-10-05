using System;

namespace shapes
{
    class Rectangle
    {
        private double height;
        private double width;

        public Rectangle()
        {
            this.height = 1;
            this.width = 1;
        }

        public Rectangle(double Jordan, double Harold)
        {
            this.height = Jordan;
            this.width = Harold;
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
        
        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                if(value < 1 || value > double.MaxValue)
                {
                    throw new OverflowException();
                }
                width = value;
            }
        }
        public double GetArea()
        {
            return (height * width);
        }

        public double GetPerimeter()
        {
            return (width*2)+(height*2);
        }
    }
}