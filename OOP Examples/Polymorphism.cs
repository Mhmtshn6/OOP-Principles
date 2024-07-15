using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Examples
{
    public class Polymorphism
    {
        public class shape   // Base class representing a general shape
        {
            public virtual void Draw() // Virtual method that can be overridden in derived classes
            {
                Console.WriteLine("Draw a Shape");// Default implementation for drawing a shape
            }
        }

        public class Square : shape { }    // Derived class representing a square, inherits from Shape

        public class Circle : shape    // Derived class representing a circle, inherits from Shape
        {
            public override void Draw()    // Override the Draw method to provide a specific implementation for Circle
            {
                Console.WriteLine("Draw a Circle");// Specific implementation for drawing a circle
            }
        }
    }
}
