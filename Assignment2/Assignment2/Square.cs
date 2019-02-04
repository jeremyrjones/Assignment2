using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Square : ICloneable
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public double Perimeter
        {
            get { return Side * 4; }
        }

        public double Area
        {
            get { return Side * Side; }
        }

        public Square(double side)
        {
            Side = side;
        }

        public object Clone()
        {
            Square result = new Square(this.Side);
            return result;
        }
    }
}
