// Liskov  Subsituition Principle : If S subType of T , When you replace S with T give the same behaver of Functionlity.
// Drived class should be replace with base class and give the same the same result or bhaveior.
// We must Created Interface class And shared it at Base class and Child class .
using System;

namespace LSP
{
    public class Rectangle
    {
        float Width;
        float Height;

        public int GetArea()
        {
            return Width * Height;
        }
    }

    public class Squer : Rectangle { }

    /// Solved

    public class Shape
    {
        public virtual double Area() { /*...*/
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public override double Area()
        {
            return Width * Width;
        }
    }

    // OR

    public class Shape
    {
        public virtual int Area()
        {
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int Area()
        {
            return Width * Height;
        }
    }

    class Square : Shape
    {
        public int Side { get; set; }

        public override int Area()
        {
            return Side * Side;
        }
    }
}
