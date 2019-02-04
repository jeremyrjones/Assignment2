using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class TestCloning
    {
        static void Main(string[] args)
        {
            Square square = new Square(4);
            Console.WriteLine($"Created square with side: {square.Side}, perimeter: {square.Perimeter}, area: {square.Area}");

            Square clonedSquare = Copy(square) as Square;
            Console.WriteLine($"Created cloned square with side: {clonedSquare.Side}, perimeter: {clonedSquare.Perimeter}, area: {clonedSquare.Area}");

            square.Side = 2;

            Console.WriteLine($"Original square now has side: {square.Side}, perimeter: {square.Perimeter}, area: {square.Area}");
            Console.WriteLine($"Cloned square still has side: {clonedSquare.Side}, perimeter: {clonedSquare.Perimeter}, area: {clonedSquare.Area}");

            Circle circle = new Circle(4);
            Console.WriteLine($"Created circle with radius: {circle.Radius}, circumference: {circle.Circumference}, area: {circle.Area}");

            Circle clonedCircle = Copy(circle) as Circle;
            Console.WriteLine($"Created cloned circle with radius: {clonedCircle.Radius}, circumference: {clonedCircle.Circumference}, area: {clonedCircle.Area}");

            circle.Radius = 2;

            Console.WriteLine($"Original circle now has radius: {circle.Radius}, circumference: {circle.Circumference}, area: {circle.Area}");
            Console.WriteLine($"Cloned circle still has radius: {clonedCircle.Radius}, circumference: {clonedCircle.Circumference}, area: {clonedCircle.Area}");
        }

        private static object Copy(ICloneable cloneable)
        {
            object result = cloneable.Clone();
            return result;
        }
    }
}
