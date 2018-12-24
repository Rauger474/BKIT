using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp2
{
    abstract class GeometryFigure
    {
        public abstract double Area();
    }


    class Rectangle : GeometryFigure, IPrint
    {
        public float Property1 { get; set; } = 0;

        public float Property2 { get; set; } = 0;

        public Rectangle(float Weight, float Height)
        {
            Property1 = Weight;
            Property2 = Height;
        }
        public override double Area()
        {
            return Property1 * Property2;
        }

        public void Print()
        {
            Console.WriteLine("Rectangle:\n" + ToString());
        }

        public override string ToString()
        {
            return "Width = " + Property1.ToString() + "\nHeight = " + Property2.ToString() + "\nS = " + Area().ToString() + "\n";
        }
    }


    class Square : Rectangle, IPrint
    {
        private float size;
        public Square(float s) : base(s, s) { size = s; }

        public new void Print()
        {
            Console.WriteLine("Square:\n" + ToString());
        }

        public override string ToString()
        {
            return "Size = " + size.ToString() + "\nS = " + Area().ToString() + "\n";
        }
    }


    class Circle : GeometryFigure, IPrint
    {
        private readonly float Property;
        public Circle(float R)
        {
            Property = R;
        }
        public override double Area()
        {
            return PI * Pow(Property, 2);
        }

        public void Print()
        {
            Console.WriteLine("Circle:\n" + ToString());
        }

        public override string ToString()
        {
            return "R = " + Property.ToString() + "\nS = " + Area().ToString() + "\n";
        }
    }


    interface IPrint
    {
        void Print();
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle One = new Rectangle(4, 3);
            One.Print();
            One.Property1 = 5;
            One.Property2 = 2;
            One.Print();
            Square Two = new Square(6)
            {
                Property1 = 4
            };
            Two.Print();
            Circle Three = new Circle(7);
            Three.Print();
            Console.ReadKey();
        }
    }
}