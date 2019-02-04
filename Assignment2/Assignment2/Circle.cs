using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Circle : ICloneable
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double Circumference
        {
            get { return (Radius * 2) * Math.PI; }
        }

        public double Area
        {
            get { return (Radius * Radius) * Math.PI; }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public object Clone()
        {
            Circle result = new Circle(this.Radius);
            return result;
        }
    }
}
